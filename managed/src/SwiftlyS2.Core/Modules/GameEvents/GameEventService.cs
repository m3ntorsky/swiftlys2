using System.Reflection;
using Microsoft.Extensions.Logging;
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.Services;
using SwiftlyS2.Shared.GameEventDefinitions;
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

  public Guid HookPre<T>(IGameEventService.GameEventHandler<T> callback) where T : IGameEvent<T> {
    GameEventCallback<T> cb = new(callback, true, _LoggerFactory, _Context);
    lock (_lock) {
      _callbacks.Add(cb);
    }
    return cb.Guid;
  }

  public Guid HookPost<T>(IGameEventService.GameEventHandler<T> callback) where T : IGameEvent<T> {
    GameEventCallback<T> cb = new(callback, false, _LoggerFactory, _Context);
    lock (_lock) {
      _callbacks.Add(cb);
    }
    return cb.Guid;
  }

  public void Unhook(Guid guid) {
    lock (_lock) {
      _callbacks.RemoveAll(callback => {
        if (callback.Guid == guid) {
          callback.Dispose();
          return true;
        }
        return false;
      });
    }
  }


  public void UnhookPre<T>() where T : IGameEvent<T> {
    lock (_lock) {
      _callbacks.RemoveAll(callback => {
        if (callback.IsPreHook && callback is GameEventCallback<T>) {
          callback.Dispose();
          return true;
        }
        return false;
      });
    }
  }

  public void UnhookPost<T>() where T : IGameEvent<T> {
    lock (_lock) {
      _callbacks.RemoveAll(callback => {
        if (!callback.IsPreHook && callback is GameEventCallback<T>) {
          callback.Dispose();
          return true;
        }
        return false;
      });
    }
  }

  public void Fire<T>() where T : IGameEvent<T> {
    // TODO: implement with all players
  }

  public void Fire<T>(Action<T> configureEvent) where T : IGameEvent<T> {
    // TODO: implement with all players
  }

  public void FireToPlayer<T>(int slot) where T : IGameEvent<T> {
    var handle = NativeGameEvents.CreateEvent(T.GetName());
    NativeGameEvents.FireEventToClient(handle, slot);
    NativeGameEvents.FreeEvent(handle);
  }

  public void FireToPlayer<T>(int slot, Action<T> configureEvent) where T : IGameEvent<T> {
    var handle = NativeGameEvents.CreateEvent(T.GetName());
    var eventObj = GameEventSingletonWrapper<T>.Borrow(handle);
    configureEvent(eventObj);
    NativeGameEvents.FireEventToClient(handle, slot);
    GameEventSingletonWrapper<T>.Return();
    NativeGameEvents.FreeEvent(handle);
  }

  public void FireToServer<T>() where T : IGameEvent<T> {
    var handle = NativeGameEvents.CreateEvent(T.GetName());
    NativeGameEvents.FireEvent(handle, true);
  }

  public void FireToServer<T>(Action<T> configureEvent) where T : IGameEvent<T> {
    var handle = NativeGameEvents.CreateEvent(T.GetName());
    var eventObj = GameEventSingletonWrapper<T>.Borrow(handle);
    configureEvent(eventObj);
    NativeGameEvents.FireEvent(handle, true);
    GameEventSingletonWrapper<T>.Return();
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