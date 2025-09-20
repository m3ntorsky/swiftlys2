using System.Runtime.InteropServices;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.Extensions;
using Microsoft.Extensions.Logging;
using SwiftlyS2.Core.Services;
using SwiftlyS2.Shared.Misc;
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Shared.Profiler;

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

  public required IContextedProfilerService Profiler { get; set; }

  public required ILoggerFactory LoggerFactory { get; set; }

  public required CoreContext Context { get; set; }

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
  private IGameEventService.GameEventHandler<T> _callback { get; init; }
  private ILogger<GameEventCallback<T>> _Logger { get; init; }
  private IContextedProfilerService _Profiler { get; init; }
  private CoreContext _Context { get; init; }
  private UnmanagedEventCallback _unmanagedCallback;

  public GameEventCallback(IGameEventService.GameEventHandler<T> callback, bool pre) {
    Guid = Guid.NewGuid();
    EventType = typeof(T);
    IsPreHook = pre;
    EventName = T.GetName();
    _callback = callback;
    _Logger = LoggerFactory!.CreateLogger<GameEventCallback<T>>();

    _unmanagedCallback = (hash, pEvent, pDontBroadcast) => {
      try {
        var category = "GameEventCallback::" + EventName;
        _Profiler!.StartRecording(category);
        if (hash != T.GetHash()) return HookResult.Continue;
        var eventObj = GameEventSingletonWrapper<T>.Borrow(pEvent);
        var result = _callback(eventObj);
        pDontBroadcast.Write(eventObj.DontBroadcast);
        GameEventSingletonWrapper<T>.Return();
        _Profiler.StopRecording(category);
        return result;
      } catch (Exception e) {
        _Logger.LogError(e, "Error in event {EventName} callback from context {ContextName}", EventName, _Context.Name);
        return HookResult.Continue;
      } 
    };
    UnmanagedWrapperPtr = Marshal.GetFunctionPointerForDelegate(_unmanagedCallback);
    NativeGameEvents.RegisterListener(EventName);
    ListenerId = IsPreHook ? NativeGameEvents.AddListenerPreCallback(UnmanagedWrapperPtr) : NativeGameEvents.AddListenerPostCallback(UnmanagedWrapperPtr);
  }
}
