using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "match_end_conditions"
/// </summary>
public interface EventMatchEndConditions : ITypedGameEvent<EventMatchEndConditions> {

  static EventMatchEndConditions ITypedGameEvent<EventMatchEndConditions>.Create() => new EventMatchEndConditionsImpl();

  static string ITypedGameEvent<EventMatchEndConditions>.GetName() => "match_end_conditions";

  static uint ITypedGameEvent<EventMatchEndConditions>.GetHash() => 0x036AAC37u;
  /// <summary>
  /// type: long
  /// </summary>
  int FragS { get; set; }

  /// <summary>
  /// type: long
  /// </summary>
  int MaxRounds { get; set; }

  /// <summary>
  /// type: long
  /// </summary>
  int WinRounds { get; set; }

  /// <summary>
  /// type: long
  /// </summary>
  int Time { get; set; }

}
