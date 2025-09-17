using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "cs_round_final_beep"
/// </summary>
public interface EventCsRoundFinalBeep : ITypedGameEvent<EventCsRoundFinalBeep> {

  static EventCsRoundFinalBeep ITypedGameEvent<EventCsRoundFinalBeep>.Wrap(IGameEvent accessor) => new EventCsRoundFinalBeepImpl(accessor);

  static string ITypedGameEvent<EventCsRoundFinalBeep>.GetName() => "cs_round_final_beep";

  static uint ITypedGameEvent<EventCsRoundFinalBeep>.GetHash() => 0x75979130u;
}
