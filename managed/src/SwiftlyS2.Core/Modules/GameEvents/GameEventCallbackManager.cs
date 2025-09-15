using System.Collections.Concurrent;

namespace SwiftlyS2.Core.GameEvents;

internal static class GameEventCallbackManager<T> where T : IGameEvent {

  private static ConcurrentDictionary<Guid, Func<T, bool>> _subscribers = new();

  public static Guid Subscribe(Func<T, bool> callback) {
    Guid guid = Guid.NewGuid();
    _subscribers[guid] = callback;
    return guid;
  }

  public static bool Unsubscribe(Guid guid) {
    return _subscribers.Remove(guid, out _);
  }

  public static void Fire(T gameEvent) {
    foreach (var subscriber in _subscribers) {
      if (!subscriber.Value(gameEvent)) {
        break;
      }
    }
  }
}