using SwiftlyS2.Shared.GameEvents;

namespace SwiftlyS2.Core.GameEvents;

internal static class GameEventSingletonWrapper<T> where T : IGameEvent<T> {

  [ThreadStatic] private static T? _Instance;
  [ThreadStatic] private static bool _Borrowed;

  public static T Borrow(nint handle)
  {
    if (_Borrowed) throw new InvalidOperationException("Unexpectedly borrowed event instance.");
    if (_Instance == null) {
      _Instance = T.Create();
    }
    _Instance.Accessor.InternalSet(handle);
    _Borrowed = true;
    return _Instance;
  }

  public static void Return()
  {
    _Instance!.DontBroadcast = false;
    _Instance!.Accessor.InternalSet(0);
    _Borrowed = false;
  }

}