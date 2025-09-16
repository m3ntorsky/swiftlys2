using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "round_freeze_end"
/// </summary>
public interface EventRoundFreezeEnd : IGameEvent<EventRoundFreezeEnd> {

  static EventRoundFreezeEnd IGameEvent<EventRoundFreezeEnd>.FromAllocated(nint ptr) => new EventRoundFreezeEndImpl(ptr, true);

  static EventRoundFreezeEnd IGameEvent<EventRoundFreezeEnd>.FromExternal(nint ptr) => new EventRoundFreezeEndImpl(ptr, false);

  static string IGameEvent<EventRoundFreezeEnd>.GetName() => "round_freeze_end";

  static uint IGameEvent<EventRoundFreezeEnd>.GetHash() => 0xD704819Du;
}
