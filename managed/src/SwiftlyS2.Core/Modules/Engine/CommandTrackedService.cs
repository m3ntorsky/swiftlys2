using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using SwiftlyS2.Shared;
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Shared.Events;
using SwiftlyS2.Shared.Misc;

namespace SwiftlyS2.Core.Modules.Engine;

internal sealed class CommandTrackedService : IDisposable
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

    private volatile CommandIdContainer currentCommandContainer;
    private readonly ConcurrentDictionary<Guid, ExecutingCommand> activeCommands;
    private readonly CancellationTokenSource cancellationTokenSource;
    private readonly ConcurrentQueue<Action<string>> pendingCallbacks;
    private readonly IEventSubscriber eventSubscriber;
    private volatile bool disposed;

    public CommandTrackedService(ISwiftlyCore core)
    {
        this.eventSubscriber = core.Event;
        pendingCallbacks = new ConcurrentQueue<Action<string>>();
        activeCommands = new ConcurrentDictionary<Guid, ExecutingCommand>();
        cancellationTokenSource = new CancellationTokenSource();
        currentCommandContainer = CommandIdContainer.Empty;

        eventSubscriber.OnCommandExecuteHook += ProcessCommand;
        eventSubscriber.OnConsoleOutput += ProcessOutput;

        StartCleanupTimer();
    }

    private void ProcessCommand(IOnCommandExecuteHookEvent @event)
    {
        if (string.IsNullOrEmpty(@event.OriginalName) || !@event.OriginalName.Contains("^wb^"))
        {
            Interlocked.Exchange(ref currentCommandContainer, CommandIdContainer.Empty);
            return;
        }

        if (@event.HookMode == HookMode.Pre)
        {
            ProcessCommandStart(@event);
        }
        else if (@event.HookMode == HookMode.Post)
        {
            ProcessCommandEnd(@event);
        }
    }

    private void ProcessOutput(IOnConsoleOutputEvent @event)
    {
        if (disposed) return;

        var commandId = currentCommandContainer?.Value ?? Guid.Empty;
        if (commandId == Guid.Empty) return;

        if (activeCommands.TryGetValue(commandId, out var command) && command.Output.Count < 100)
        {
            command.Output.Enqueue(@event.Message);
        }
    }

    private void ProcessCommandStart(IOnCommandExecuteHookEvent @event)
    {
        if (pendingCallbacks.TryDequeue(out var callback))
        {
            var newCommandId = Guid.NewGuid();
            var newCommand = new ExecutingCommand(callback);

            if (activeCommands.TryAdd(newCommandId, newCommand))
            {
                var newContainer = new CommandIdContainer(newCommandId);
                Interlocked.Exchange(ref currentCommandContainer, newContainer);
                @event.SetCommandName(@event.OriginalName.Replace("^wb^", string.Empty));
            }
        }
        else
        {
            Interlocked.Exchange(ref currentCommandContainer, CommandIdContainer.Empty);
        }
    }

    private void ProcessCommandEnd(IOnCommandExecuteHookEvent @event)
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
        eventSubscriber.OnCommandExecuteHook -= ProcessCommand;
        eventSubscriber.OnConsoleOutput -= ProcessOutput;

        while (pendingCallbacks.TryDequeue(out _)) { }
        activeCommands.Clear();

        cancellationTokenSource.Dispose();
    }
}