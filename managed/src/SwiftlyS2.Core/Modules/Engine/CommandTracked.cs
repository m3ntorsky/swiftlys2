using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using SwiftlyS2.Shared;
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Shared.Memory;
using SwiftlyS2.Shared.Services;
using SwiftlyS2.Shared.ConsoleOutput;

namespace SwiftlyS2.Core.Modules.Engine;

internal sealed class CommandTracked : IDisposable
{
    private sealed record CommandIdContainer(Guid Value)
    {
        public static readonly CommandIdContainer Empty = new(Guid.Empty);
    }

    private readonly record struct ExecutingCommand(Action<string> Callback)
    {
        public ConcurrentQueue<string> Output { get; } = new();
        public DateTime Created { get; } = DateTime.UtcNow;
        public bool IsExpired => DateTime.UtcNow - Created > TimeSpan.FromMilliseconds(5000);
    }

    private volatile bool disposed;
    private readonly CancellationTokenSource cancellationTokenSource;
    private readonly ConcurrentQueue<Action<string>> pendingCallbacks;
    private readonly ConcurrentDictionary<Guid, ExecutingCommand> activeCommands;
    private readonly IMemoryService memoryService;
    private readonly IConsoleOutputService consoleOutputService;
    private readonly IGameDataService gameDataService;
    private volatile CommandIdContainer currentCommandContainer;

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

    private void ProcessCommandStart(nint a5)
    {
        // var commandNamePtr = GetCommandNamePointer(a5);
        // if (commandNamePtr == nint.Zero) return;

        // var commandStr = Marshal.PtrToStringAnsi(commandNamePtr);
        // if (string.IsNullOrEmpty(commandStr) || !commandStr.Contains("^wb^"))
        // {
        //     Interlocked.Exchange(ref currentCommandContainer, CommandIdContainer.Empty);
        //     return;
        // }

        // if (pendingCallbacks.TryDequeue(out var callback))
        // {
        //     var newCommandId = Guid.NewGuid();
        //     var newCommand = new ExecutingCommand(callback);

        //     if (activeCommands.TryAdd(newCommandId, newCommand))
        //     {
        //         var newContainer = new CommandIdContainer(newCommandId);
        //         Interlocked.Exchange(ref currentCommandContainer, newContainer);
        //         CleanCommandName(commandNamePtr, commandStr);
        //     }
        // }
        // else
        // {
        //     Interlocked.Exchange(ref currentCommandContainer, CommandIdContainer.Empty);
        // }
    }

    private void ProcessCommandEnd()
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
                command.Callback?.Invoke(output.ToString());
            });
        }
    }

    private static void CleanCommandName(nint commandPtr, string commandStr)
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
        foreach (var kvp in activeCommands.ToArray())
        {
            if (kvp.Value.IsExpired)
            {
                activeCommands.TryRemove(kvp.Key, out _);
            }
        }
    }

    public void EnqueueCommand(Action<string> callback)
    {
        if (disposed || callback == null) return;

        pendingCallbacks.Enqueue(callback);
    }

    public void Dispose()
    {
        if (disposed) return;
        disposed = true;

        cancellationTokenSource.Cancel();
        // executeCommandHook?.RemoveHook(hookId);
        // consoleOutputService.UnregisterConsoleOutputListener(outputListenerId);

        while (pendingCallbacks.TryDequeue(out _)) { }
        activeCommands.Clear();

        cancellationTokenSource.Dispose();
    }
}