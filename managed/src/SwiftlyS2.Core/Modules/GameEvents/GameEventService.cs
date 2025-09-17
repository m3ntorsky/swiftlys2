using System.Reflection;
using Microsoft.Extensions.Logging;
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.Services;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.Misc;

namespace SwiftlyS2.Core.GameEvents;

internal class GameEventService : IGameEventService, IDisposable {

  private ILoggerFactory _LoggerFactory { get; init; }
  private CoreContext _Context { get; init; }

  public GameEventService(ILoggerFactory loggerFactory, CoreContext context) {
    _LoggerFactory = loggerFactory;
    _Context = context;
  }

  private readonly List<GameEventCallback> _callbacks = new();
  private object _lock = new();

  public Guid HookPre<T>(Func<T, HookResult> callback) where T : ITypedGameEvent<T> {
    GameEventCallback<T> cb = new(callback, true, _LoggerFactory, _Context);
    lock (_lock) {
      _callbacks.Add(cb);
    }
    return cb.Guid;
  }

  public Guid HookPost<T>(Func<T, HookResult> callback) where T : ITypedGameEvent<T> {
    GameEventCallback<T> cb = new(callback, false, _LoggerFactory, _Context);
    lock (_lock) {
      _callbacks.Add(cb);
    }
    return cb.Guid;
  }

  public void Unhook(Guid guid) {
    lock (_lock) {
      for (int i = 0; i < _callbacks.Count; i++) {
        var callback = _callbacks[i];
        if (callback.Guid == guid) {
          callback.Dispose();
          _callbacks.RemoveAt(i);
          break;
        }
      }
    }
  }


  public void UnhookPre<T>() where T : ITypedGameEvent<T> {
    lock (_lock) {
      for (int i = 0; i < _callbacks.Count; i++) {
        var callback = _callbacks[i];
        if (callback.IsPreHook) {
          callback.Dispose();
          _callbacks.RemoveAt(i);
        }
      }
    }
  }

  public void UnhookPost<T>() where T : ITypedGameEvent<T> {
    lock (_lock) {
      for (int i = 0; i < _callbacks.Count; i++) {
        var callback = _callbacks[i];
        if (!callback.IsPreHook) {
          callback.Dispose();
          _callbacks.RemoveAt(i);
        }
      }
    }
  }

  public T Create<T>() where T : ITypedGameEvent<T> {
    unsafe {
      var accessor = new GameEvent((nint)NativeGameEvents.CreateEvent(T.GetName()), true);
      return T.Wrap(accessor);
    }
  }

  public void Dispose() {
    lock (_lock) {
      foreach (var callback in _callbacks)
      {
        callback.Dispose();
      }
      _callbacks.Clear();
    }
  }
}