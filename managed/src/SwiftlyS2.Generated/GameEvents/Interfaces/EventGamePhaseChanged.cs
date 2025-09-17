using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "game_phase_changed"
/// </summary>
public interface EventGamePhaseChanged : ITypedGameEvent<EventGamePhaseChanged> {

  static EventGamePhaseChanged ITypedGameEvent<EventGamePhaseChanged>.Create() => new EventGamePhaseChangedImpl();

  static string ITypedGameEvent<EventGamePhaseChanged>.GetName() => "game_phase_changed";

  static uint ITypedGameEvent<EventGamePhaseChanged>.GetHash() => 0x9FBE9554u;
  /// <summary>
  /// type: short
  /// </summary>
  short NewPhase { get; set; }

}
