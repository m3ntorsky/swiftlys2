using System.Runtime.InteropServices;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.Extensions;
using Microsoft.Extensions.Logging;
using SwiftlyS2.Core.Services;
using SwiftlyS2.Shared.Misc;

namespace SwiftlyS2.Core.GameEvents;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate HookResult UnmanagedEventCallback(uint hash, nint pEvent, nint pDontBroadcast);

internal abstract class GameEventCallback : IEquatable<GameEventCallback> {

  public Guid Guid { get; init; }

  public string EventName { get; init; } = "";

  public Type EventType { get; init; } = typeof(object);

  public bool IsPreHook { get; init; }

  public nint UnmanagedWrapperPtr { get; init; }

  public bool Equals(GameEventCallback? other) {
    if (other is null) return false;
    return Guid == other.Guid;
  }

  public override bool Equals(object? obj)
  {
    if (ReferenceEquals(this, obj)) return true;
    return obj is GameEventCallback other && Equals(other);
  }

  public override int GetHashCode() {
    return Guid.GetHashCode();
  }
}

internal class GameEventCallback<T> : GameEventCallback where T : IGameEvent<T>
{
  private Func<T, HookResult> _callback { get; init; }
  private ILogger<GameEventCallback<T>> _logger { get; init; }
  private CoreContext _Context { get; init; }

  private UnmanagedEventCallback _unmanagedCallback;

  public GameEventCallback(Func<T, HookResult> callback, bool pre, ILoggerFactory loggerFactory, CoreContext context) {
    Guid = Guid.NewGuid();
    EventType = typeof(T);
    IsPreHook = pre;
    EventName = T.GetName();
    _Context = context;
    _callback = callback;
    _logger = loggerFactory.CreateLogger<GameEventCallback<T>>();

    _unmanagedCallback = (hash, pEvent, pDontBroadcast) => {
      try {
        if (hash != T.GetHash()) return HookResult.Continue;
        var @event = T.FromExternal(pEvent);
        var result = _callback(@event);
        pDontBroadcast.Write(@event.DontBroadcast);
        return result;
      } catch (Exception e) {
        _logger.LogError(e, "Error in event {EventName} callback from context {ContextName}", EventName, _Context.Name);
        return HookResult.Continue;
      } 
    };
    UnmanagedWrapperPtr = Marshal.GetFunctionPointerForDelegate(_unmanagedCallback);
  }

  ~GameEventCallback() {
    throw new Exception("GameEventCallback destructor called");
  }
}
