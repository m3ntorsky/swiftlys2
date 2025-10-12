using System.Runtime.InteropServices;
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Shared.ConsoleOutput;
using Microsoft.Extensions.Logging;
using SwiftlyS2.Shared.Profiler;

namespace SwiftlyS2.Core.ConsoleOutput;

internal delegate void ConsoleOutputListenerCallbackDelegate(nint message);

internal abstract class ConsoleOutputCallbackBase : IDisposable
{
    public Guid Guid { get; protected init; }
    public IContextedProfilerService Profiler { get; }
    public ILoggerFactory LoggerFactory { get; }

    protected ConsoleOutputCallbackBase(ILoggerFactory loggerFactory, IContextedProfilerService profiler)
    {
        LoggerFactory = loggerFactory;
        Profiler = profiler;
    }

    public abstract void Dispose();
}

internal class ConsoleOutputListenerCallback : ConsoleOutputCallbackBase
{
    private IConsoleOutputService.ConsoleOutputHandler _handler;
    private ConsoleOutputListenerCallbackDelegate _unmanagedCallback;
    private nint _unmanagedCallbackPtr;
    private ulong _nativeListenerId;
    private ILogger<ConsoleOutputListenerCallback> _logger;

    public ConsoleOutputListenerCallback(IConsoleOutputService.ConsoleOutputHandler handler, ILoggerFactory loggerFactory, IContextedProfilerService profiler)
        : base(loggerFactory, profiler)
    {
        _logger = LoggerFactory.CreateLogger<ConsoleOutputListenerCallback>();
        Guid = Guid.NewGuid();

        _handler = handler;

        _unmanagedCallback = (messagePtr) =>
        {
            try
            {
                var category = "ConsoleOutputListenerCallback";
                Profiler.StartRecording(category);
                var messageString = Marshal.PtrToStringUTF8(messagePtr)!;
                _handler(messageString);
                Profiler.StopRecording(category);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Failed to handle console output listener.");
            }
        };

        _unmanagedCallbackPtr = Marshal.GetFunctionPointerForDelegate(_unmanagedCallback);
        _nativeListenerId = NativeConsoleOutput.AddConsoleListener(_unmanagedCallbackPtr);
    }

    public override void Dispose()
    {
        try
        {
            NativeConsoleOutput.RemoveConsoleListener(_nativeListenerId);
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Failed to unregister console output listener.");
        }

        GC.SuppressFinalize(this);
    }
}