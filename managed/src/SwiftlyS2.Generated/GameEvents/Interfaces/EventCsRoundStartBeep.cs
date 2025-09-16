using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "cs_round_start_beep"
/// </summary>
public interface EventCsRoundStartBeep : IGameEvent<EventCsRoundStartBeep> {

  static EventCsRoundStartBeep IGameEvent<EventCsRoundStartBeep>.FromAllocated(nint ptr) => new EventCsRoundStartBeepImpl(ptr, true);

  static EventCsRoundStartBeep IGameEvent<EventCsRoundStartBeep>.FromExternal(nint ptr) => new EventCsRoundStartBeepImpl(ptr, false);

  static string IGameEvent<EventCsRoundStartBeep>.GetName() => "cs_round_start_beep";

  static uint IGameEvent<EventCsRoundStartBeep>.GetHash() => 0x4DB83630u;
}
