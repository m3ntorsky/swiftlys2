using System.Reflection;

namespace SwiftlyS2.Core.GameEvents;

internal class GameEventSubscriber : IDisposable {

  private readonly List<Guid> _callbacks = new();
  private readonly HashSet<Type> _types = new();
  private object _lock = new();

  public Guid Subscribe<T>(Func<T, bool> callback) where T : IGameEvent {
    var guid = GameEventCallbackManager<T>.Subscribe(callback);
    lock (_lock) {
      _types.Add(typeof(T));
      _callbacks.Add(guid);
    }
    return guid;
  }

  public void Unsubscribe<T>(Guid guid) where T : IGameEvent {
    GameEventCallbackManager<T>.Unsubscribe(guid);
    lock (_lock) {
      _callbacks.Remove(guid);
    }
  }


  public void UnsubscribeAll<T>() where T : IGameEvent {
    lock (_lock) {
      for (int i = 0; i < _callbacks.Count; i++) {
        GameEventCallbackManager<T>.Unsubscribe(_callbacks[i]);
        _callbacks.RemoveAt(i);
      }
    }
  }

  public void Fire<T>(T gameEvent) where T : IGameEvent {
    GameEventCallbackManager<T>.Fire(gameEvent);
  }

  public void Dispose() {
    lock (_lock) {
      foreach (var type in _types) {
        foreach (var guid in _callbacks) {
          typeof(GameEventCallbackManager<>)
            .MakeGenericType(type)
            .GetMethod("Unsubscribe", BindingFlags.Static | BindingFlags.Public)?
            .Invoke(null, new object[] { guid });
        }
      }
      _types.Clear();
      _callbacks.Clear();
    }
  }
}