using System.Runtime.InteropServices;

namespace SwiftlyS2.Core.GameEvents;

internal static class GameEventPublisher {

  [UnmanagedCallersOnly]
  public static void OnGameEventFired(ulong hash, nint handle) {
    // should be generated
    if (hash == 0) {
      GameEventCallbackManager<EventTest>.Fire(new EventTest(handle));
      return;
    }
    throw new Exception();
  }
}