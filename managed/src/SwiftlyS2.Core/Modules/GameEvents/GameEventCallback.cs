namespace SwiftlyS2.Core.GameEvents;

internal abstract class GameEventCallback {

  public abstract bool Fire(ulong hash, nint handle);
}

internal class GameEventCallback<T> where T : GameEvent, new() {

  private T _dummy = new();
  private Func<T, bool> _callback { get; init; }

  public GameEventCallback(Func<T, bool> callback) {
    _callback = callback;
  }

  public bool Fire(ulong hash, nint handle) {
    if (hash != _dummy.Hash) return true;
    T ev = new();
    // ev.FromExternal(handle);
    return _callback(ev);
  }
}
