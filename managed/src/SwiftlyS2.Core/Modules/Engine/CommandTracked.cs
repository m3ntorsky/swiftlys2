using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using SwiftlyS2.Shared;
using SwiftlyS2.Shared.Memory;
using SwiftlyS2.Shared.Services;
using SwiftlyS2.Shared.ConsoleOutput;

namespace SwiftlyS2.Core.Modules.Engine;

internal sealed class CommandTracked : IDisposable
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    private delegate nint ExecuteCommandDelegate(nint a1, int a2, uint a3, nint a4, nint a5);

    private sealed class CommandIdContainer
    {
        public static readonly CommandIdContainer Empty = new(Guid.Empty);

        public Guid Value;
        public CommandIdContainer(Guid value) => Value = value;
    }

    private readonly record struct ExecutingCommand(Action<string> Callback)
    {
        public ConcurrentQueue<string> Output { get; } = new();
        public DateTime Created { get; } = DateTime.UtcNow;
        public bool IsExpired => DateTime.UtcNow - Created > TimeSpan.FromMilliseconds(5000);
    }

    private readonly CancellationTokenSource cancellationTokenSource;
    private readonly ConcurrentQueue<Action<string>> pendingCallbacks;
    private readonly ConcurrentDictionary<Guid, ExecutingCommand> activeCommands;
    private readonly IMemoryService memoryService;
    private readonly IConsoleOutputService consoleOutputService;
    private readonly IGameDataService gameDataService;
    private volatile CommandIdContainer currentCommandContainer;
    private volatile bool hooksInitialized;
    private volatile bool disposed;
    private readonly object initializationLock = new();
    private Guid hookId;
    private Guid outputListenerId;
    private IUnmanagedFunction<ExecuteCommandDelegate>? executeCommandHook;

    public CommandTracked(ISwiftlyCore swiftlyCore)
    {
        memoryService = swiftlyCore.Memory;
        consoleOutputService = swiftlyCore.ConsoleOutput;
        gameDataService = swiftlyCore.GameData;
        pendingCallbacks = new ConcurrentQueue<Action<string>>();
        activeCommands = new ConcurrentDictionary<Guid, ExecutingCommand>();
        cancellationTokenSource = new CancellationTokenSource();
        currentCommandContainer = CommandIdContainer.Empty;

        StartCleanupTimer();
    }

    private void EnsureHooksInitialized()
    {
        if (hooksInitialized || gameDataService == null) return;

        lock (initializationLock)
        {
            if (hooksInitialized) return;

            try
            {
                var signature = gameDataService.GetSignature("Cmd_ExecuteCommand");
                if (signature == nint.Zero) return;

                executeCommandHook = memoryService.GetUnmanagedFunctionByAddress<ExecuteCommandDelegate>(signature);
                hookId = executeCommandHook.AddHook((next) =>
                {
                    return (a1, a2, a3, a4, a5) =>
                    {
                        ProcessCommandStart(a5);
                        var result = next()(a1, a2, a3, a4, a5);
                        ProcessCommandEnd();
                        return result;
                    };
                });

                outputListenerId = consoleOutputService.RegisterConsoleOutputListener((message) =>
                {
                    if (disposed) return;

                    var commandId = currentCommandContainer?.Value ?? Guid.Empty;
                    if (commandId == Guid.Empty) return;

                    try
                    {
                        if (activeCommands.TryGetValue(commandId, out var command) && command.Output.Count < 100)
                        {
                            command.Output.Enqueue(message);
                        }
                    }
                    catch { }
                });

                Thread.MemoryBarrier();
                hooksInitialized = true;
            }
            catch { }
        }
    }

    private void ProcessCommandStart(nint a5)
    {
        try
        {
            var commandNamePtr = GetCommandNamePointer(a5);
            if (commandNamePtr == nint.Zero) return;

            var commandStr = Marshal.PtrToStringAnsi(commandNamePtr);
            if (string.IsNullOrEmpty(commandStr) || !commandStr.Contains("^wb^"))
            {
                Interlocked.Exchange(ref currentCommandContainer, CommandIdContainer.Empty);
                return;
            }

            if (pendingCallbacks.TryDequeue(out var callback))
            {
                var newCommandId = Guid.NewGuid();
                var newCommand = new ExecutingCommand(callback);

                if (activeCommands.TryAdd(newCommandId, newCommand))
                {
                    var newContainer = new CommandIdContainer(newCommandId);
                    Interlocked.Exchange(ref currentCommandContainer, newContainer);
                    CleanCommandName(commandNamePtr, commandStr);
                }
            }
            else
            {
                Interlocked.Exchange(ref currentCommandContainer, CommandIdContainer.Empty);
            }
        }
        catch { }
    }

    private void ProcessCommandEnd()
    {
        try
        {
            var previousContainer = Interlocked.Exchange(ref currentCommandContainer, CommandIdContainer.Empty);
            var commandId = previousContainer?.Value ?? Guid.Empty;

            if (commandId != Guid.Empty && activeCommands.TryRemove(commandId, out var command))
            {
                var output = new StringBuilder();
                while (command.Output.TryDequeue(out var line))
                {
                    if (output.Length > 0) output.AppendLine();
                    output.Append(line);
                }

                Task.Run(() =>
                {
                    try
                    {
                        command.Callback?.Invoke(output.ToString());
                    }
                    catch { }
                });
            }
        }
        catch { }
    }

    private static nint GetCommandNamePointer(nint a5)
    {
        try
        {
            if (a5 == nint.Zero || a5 >= nint.MaxValue) return nint.Zero;
            var basePtr = Marshal.ReadIntPtr(a5 + 0x440);

            if (basePtr == nint.Zero || basePtr >= nint.MaxValue) return nint.Zero;
            return Marshal.ReadIntPtr(basePtr);
        }
        catch
        {
            return nint.Zero;
        }
    }

    private static void CleanCommandName(nint commandPtr, string commandStr)
    {
        try
        {
            var cleanedCommand = commandStr.Replace("^wb^", string.Empty);
            if (cleanedCommand.Length >= commandStr.Length) return;

            var cleanedBytes = Encoding.ASCII.GetBytes(cleanedCommand + "\0");
            var maxLength = Encoding.ASCII.GetByteCount(commandStr + "\0");

            if (cleanedBytes.Length <= maxLength)
            {
                Marshal.Copy(cleanedBytes, 0, commandPtr, cleanedBytes.Length);
            }
        }
        catch { }
    }

    private void StartCleanupTimer()
    {
        Task.Run(async () =>
        {
            while (!cancellationTokenSource.Token.IsCancellationRequested)
            {
                try
                {
                    await Task.Delay(TimeSpan.FromMilliseconds(200), cancellationTokenSource.Token);
                    CleanupExpiredCommands();
                }
                catch { }
            }
        }, cancellationTokenSource.Token);
    }

    private void CleanupExpiredCommands()
    {
        try
        {
            foreach (var kvp in activeCommands.ToArray())
            {
                if (kvp.Value.IsExpired)
                {
                    activeCommands.TryRemove(kvp.Key, out _);
                }
            }
        }
        catch { }
    }

    public void EnqueueCommand(Action<string> callback)
    {
        if (disposed || callback == null) return;

        EnsureHooksInitialized();

        try
        {
            pendingCallbacks.Enqueue(callback);
        }
        catch { }
    }

    public void Dispose()
    {
        if (disposed) return;
        disposed = true;

        try
        {
            cancellationTokenSource.Cancel();
            executeCommandHook?.RemoveHook(hookId);
            consoleOutputService.UnregisterConsoleOutputListener(outputListenerId);

            while (pendingCallbacks.TryDequeue(out _)) { }
            activeCommands.Clear();

            cancellationTokenSource.Dispose();
        }
        catch { }
    }
}