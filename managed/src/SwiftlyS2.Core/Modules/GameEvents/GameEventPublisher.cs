using System.Runtime.InteropServices;
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Shared.GameEvents;

namespace SwiftlyS2.Core.GameEvents;

internal static class GameEventPublisher {

  private static Dictionary<GameEventCallback, ulong> _callbacks = new();
  private static object _lock = new();

  public static void Subscribe(GameEventCallback callback) {
    lock (_lock) {
      unsafe {
        NativeGameEvents.RegisterListener(callback.EventName);
        if (callback.IsPreHook) {
          _callbacks[callback] = NativeGameEvents.AddListenerPreCallback(callback.UnmanagedWrapperPtr);
        } else {
          _callbacks[callback] = NativeGameEvents.AddListenerPostCallback(callback.UnmanagedWrapperPtr);
        }
      }
    }
  }

  public static void Unsubscribe(GameEventCallback callback) {
    lock (_lock) {
      if (callback.IsPreHook) {
        NativeGameEvents.RemoveListenerPreCallback(_callbacks[callback]);
      } else {
        NativeGameEvents.RemoveListenerPostCallback(_callbacks[callback]);
      }
      _callbacks.Remove(callback);
    }
  }
}