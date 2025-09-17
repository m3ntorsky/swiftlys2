using System.Runtime.InteropServices;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.Extensions;
using Microsoft.Extensions.Logging;
using SwiftlyS2.Core.Services;
using SwiftlyS2.Shared.Misc;
using SwiftlyS2.Core.Natives;

namespace SwiftlyS2.Core.GameEvents;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate HookResult UnmanagedEventCallback(uint hash, nint pEvent, nint pDontBroadcast);

internal abstract class GameEventCallback : IEquatable<GameEventCallback>, IDisposable {

  public Guid Guid { get; init; }

  public string EventName { get; init; } = "";

  public Type EventType { get; init; } = typeof(object);

  public bool IsPreHook { get; init; }

  public nint UnmanagedWrapperPtr { get; init; }

  public ulong ListenerId { get; init; }

  public void Dispose() {
    if (IsPreHook) {
      NativeGameEvents.RemoveListenerPreCallback(ListenerId);
    } else {
      NativeGameEvents.RemoveListenerPostCallback(ListenerId);
    }
  }

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

internal class GameEventCallback<T> : GameEventCallback, IDisposable where T : IGameEvent<T>
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
    Console.WriteLine(EventName);
    UnmanagedWrapperPtr = Marshal.GetFunctionPointerForDelegate(_unmanagedCallback);
    NativeGameEvents.RegisterListener(EventName);
    ListenerId = IsPreHook ? NativeGameEvents.AddListenerPreCallback(UnmanagedWrapperPtr) : NativeGameEvents.AddListenerPostCallback(UnmanagedWrapperPtr);
  }
}
