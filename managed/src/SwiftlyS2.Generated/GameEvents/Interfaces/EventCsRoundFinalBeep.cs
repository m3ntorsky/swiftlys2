using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "cs_round_final_beep"
/// </summary>
public interface EventCsRoundFinalBeep : IGameEvent<EventCsRoundFinalBeep> {

  static EventCsRoundFinalBeep IGameEvent<EventCsRoundFinalBeep>.FromAllocated(nint ptr) => new EventCsRoundFinalBeepImpl(ptr, true);

  static EventCsRoundFinalBeep IGameEvent<EventCsRoundFinalBeep>.FromExternal(nint ptr) => new EventCsRoundFinalBeepImpl(ptr, false);

  static string IGameEvent<EventCsRoundFinalBeep>.GetName() => "cs_round_final_beep";

  static uint IGameEvent<EventCsRoundFinalBeep>.GetHash() => 0x75979130u;
}
