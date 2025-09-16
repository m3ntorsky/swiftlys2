using SwiftlyS2.Core.GameEvents;

namespace SwiftlyS2.Shared.GameEvents;

public interface EventTest : IGameEvent<EventTest> {

  static EventTest IGameEvent<EventTest>.FromAllocated(nint ptr) => new EventTestImpl(ptr, true);

  static EventTest IGameEvent<EventTest>.FromExternal(nint ptr) => new EventTestImpl(ptr, false);

  static string IGameEvent<EventTest>.GetName() => "player_team";

  static uint IGameEvent<EventTest>.GetHash() => 0x12345678;
}