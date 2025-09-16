using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "survival_paradrop_break"
/// </summary>
public interface EventSurvivalParadropBreak : IGameEvent<EventSurvivalParadropBreak> {

  static EventSurvivalParadropBreak IGameEvent<EventSurvivalParadropBreak>.FromAllocated(nint ptr) => new EventSurvivalParadropBreakImpl(ptr, true);

  static EventSurvivalParadropBreak IGameEvent<EventSurvivalParadropBreak>.FromExternal(nint ptr) => new EventSurvivalParadropBreakImpl(ptr, false);

  static string IGameEvent<EventSurvivalParadropBreak>.GetName() => "survival_paradrop_break";

  static uint IGameEvent<EventSurvivalParadropBreak>.GetHash() => 0xEBA7AD7Bu;
  /// <summary>
  /// type: short
  /// </summary>
  short EntityID { get; set; }

}
