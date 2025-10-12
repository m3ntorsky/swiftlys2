using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using SwiftlyS2.Shared.Memory;
using SwiftlyS2.Shared.Services;
using SwiftlyS2.Shared.ConsoleOutput;

namespace SwiftlyS2.Core.Modules.Engine;

internal sealed class CommandTracked : IDisposable
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    private delegate nint ExecuteCommandDelegate(nint a1, int a2, uint a3, nint a4, nint a5);

    private static CommandTracked? instance;

    private readonly ConcurrentQueue<CommandCallback> pendingCommands;
    private readonly ConcurrentQueue<string> capturedOutput;
    private readonly IMemoryService memoryService;
    private readonly IConsoleOutputService consoleOutputService;
    private readonly CancellationTokenSource cancellationTokenSource;

    private IUnmanagedFunction<ExecuteCommandDelegate>? executeCommandHook;
    private Guid hookId;
    private Guid outputListenerId;
    private volatile int isCapturing;
    private volatile int shouldProcessCallback;
    private volatile bool disposed;

    private readonly struct CommandCallback
    {
        public readonly string Command;
        public readonly Action<string> Callback;
        public readonly DateTime Timestamp;

        public CommandCallback(string command, Action<string> callback)
        {
            Command = command;
            Callback = callback;
            Timestamp = DateTime.UtcNow;
        }

        public bool IsExpired => DateTime.UtcNow - Timestamp > TimeSpan.FromMilliseconds(10000);
    }

    private CommandTracked(IMemoryService memoryService, IGameDataService gameDataService, IConsoleOutputService consoleOutputService)
    {
        this.memoryService = memoryService;
        this.consoleOutputService = consoleOutputService;
        pendingCommands = new ConcurrentQueue<CommandCallback>();
        capturedOutput = new ConcurrentQueue<string>();
        cancellationTokenSource = new CancellationTokenSource();

        InitializeHooks(gameDataService);
        StartCleanupTimer();
    }

    private void InitializeHooks(IGameDataService gameDataService)
    {
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

            outputListenerId = consoleOutputService.RegisterConsoleOutputListener(OnConsoleOutput);
        }
        catch { }
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
                Interlocked.Exchange(ref shouldProcessCallback, 0);
                return;
            }

            CleanCommandName(commandNamePtr, commandStr);
            ClearCapturedOutput();
            Interlocked.Exchange(ref isCapturing, 1);
            Interlocked.Exchange(ref shouldProcessCallback, 1);
        }
        catch { }
    }

    private void ProcessCommandEnd()
    {
        try
        {
            var wasCapturing = Interlocked.Exchange(ref isCapturing, 0);
            var shouldProcess = Interlocked.Exchange(ref shouldProcessCallback, 0);
            if (shouldProcess == 1 && pendingCommands.TryDequeue(out var callback))
            {
                var output = wasCapturing == 1 ? GetCapturedOutput() : string.Empty;
                callback.Callback?.Invoke(output);
            }
        }
        catch { }
    }

    private static nint GetCommandNamePointer(nint a5)
    {
        try
        {
            var basePtr = Marshal.ReadIntPtr(a5 + 0x440);
            return basePtr != nint.Zero ? Marshal.ReadIntPtr(basePtr) : nint.Zero;
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
            var cleanedBytes = System.Text.Encoding.ASCII.GetBytes(cleanedCommand + "\0");
            Marshal.Copy(cleanedBytes, 0, commandPtr, cleanedBytes.Length);
        }
        catch { }
    }

    private void ClearCapturedOutput()
    {
        while (capturedOutput.TryDequeue(out _)) { }
    }

    private string GetCapturedOutput()
    {
        var outputs = new List<string>();
        while (capturedOutput.TryDequeue(out var output))
        {
            outputs.Add(output);
        }
        return outputs.Count > 0 ? string.Join("\n", outputs) : string.Empty;
    }

    private void OnConsoleOutput(string message)
    {
        if (disposed || isCapturing == 0 || capturedOutput.Count >= 100) return;

        try
        {
            capturedOutput.Enqueue(message);
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
                    await Task.Delay(TimeSpan.FromMilliseconds(5000), cancellationTokenSource.Token);
                    CleanupExpiredCommands();
                }
                catch { }
            }
        }, cancellationTokenSource.Token);
    }

    private void CleanupExpiredCommands()
    {
        var validCommands = new List<CommandCallback>();
        var originalCount = pendingCommands.Count;

        while (pendingCommands.TryDequeue(out var command))
        {
            if (!command.IsExpired)
            {
                validCommands.Add(command);
            }
        }

        foreach (var command in validCommands)
        {
            pendingCommands.Enqueue(command);
        }
    }

    public static void Initialize(IMemoryService memoryService, IGameDataService gameDataService, IConsoleOutputService consoleOutputService)
    {
        try
        {
            var newInstance = new CommandTracked(memoryService, gameDataService, consoleOutputService);
            Interlocked.Exchange(ref instance, newInstance);
        }
        catch { }
    }

    public static CommandTracked? Instance => instance;

    public void EnqueueCommand(string command, Action<string> callback)
    {
        if (disposed || callback == null) return;

        try
        {
            pendingCommands.Enqueue(new CommandCallback(command, callback));
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

            ClearCapturedOutput();
            while (pendingCommands.TryDequeue(out _)) { }

            cancellationTokenSource.Dispose();
        }
        catch { }
    }
}