using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "survival_paradrop_break"
/// </summary>
public interface EventSurvivalParadropBreak : ITypedGameEvent<EventSurvivalParadropBreak> {

  static EventSurvivalParadropBreak ITypedGameEvent<EventSurvivalParadropBreak>.Create() => new EventSurvivalParadropBreakImpl();

  static string ITypedGameEvent<EventSurvivalParadropBreak>.GetName() => "survival_paradrop_break";

  static uint ITypedGameEvent<EventSurvivalParadropBreak>.GetHash() => 0xEBA7AD7Bu;
  /// <summary>
  /// type: short
  /// </summary>
  short EntityID { get; set; }

}
