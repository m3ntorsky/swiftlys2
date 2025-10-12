using Microsoft.Extensions.Logging;
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Shared.ConsoleOutput;
using SwiftlyS2.Shared.Profiler;

namespace SwiftlyS2.Core.ConsoleOutput;

internal class ConsoleOutputService : IConsoleOutputService, IDisposable
{
    private List<ConsoleOutputCallbackBase> _callbacks = new();
    private ILogger<ConsoleOutputService> _logger { get; init; }
    private ILoggerFactory _loggerFactory { get; init; }
    private IContextedProfilerService _profiler { get; init; }

    private object _lock = new();

    public ConsoleOutputService(ILogger<ConsoleOutputService> logger, ILoggerFactory loggerFactory, IContextedProfilerService profiler)
    {
        _logger = logger;
        _loggerFactory = loggerFactory;
        _profiler = profiler;
    }

    public Guid RegisterConsoleOutputListener(IConsoleOutputService.ConsoleOutputHandler handler)
    {
        var callback = new ConsoleOutputListenerCallback(handler, _loggerFactory, _profiler);
        lock (_lock)
        {
            _callbacks.Add(callback);
        }

        return callback.Guid;
    }

    public void UnregisterConsoleOutputListener(Guid guid)
    {
        lock (_lock)
        {
            _callbacks.RemoveAll(callback =>
            {
                if (callback.Guid == guid)
                {
                    callback.Dispose();
                    return true;
                }
                return false;
            });
        }
    }

    public bool IsFilterEnabled()
    {
        return NativeConsoleOutput.IsEnabled();
    }

    public void ToggleFilter()
    {
        NativeConsoleOutput.ToggleFilter();
    }

    public void ReloadFilterConfiguration()
    {
        NativeConsoleOutput.ReloadFilterConfiguration();
    }

    public bool NeedsFiltering(string message)
    {
        return NativeConsoleOutput.NeedsFiltering(message);
    }

    public string GetCounterText()
    {
        return NativeConsoleOutput.GetCounterText();
    }

    public void WriteToServerConsole(string message)
    {
        NativeEngineHelpers.SendMessageToConsole(message);
    }

    public void Dispose()
    {
        lock (_lock)
        {
            foreach (var callback in _callbacks)
            {
                callback.Dispose();
            }
            _callbacks.Clear();
        }
        GC.SuppressFinalize(this);
    }
}