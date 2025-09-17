using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "cs_round_start_beep"
/// </summary>
public interface EventCsRoundStartBeep : ITypedGameEvent<EventCsRoundStartBeep> {

  static EventCsRoundStartBeep ITypedGameEvent<EventCsRoundStartBeep>.Wrap(IGameEvent accessor) => new EventCsRoundStartBeepImpl(accessor);

  static string ITypedGameEvent<EventCsRoundStartBeep>.GetName() => "cs_round_start_beep";

  static uint ITypedGameEvent<EventCsRoundStartBeep>.GetHash() => 0x4DB83630u;
}
