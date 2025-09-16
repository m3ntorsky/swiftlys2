using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "game_phase_changed"
/// </summary>
public interface EventGamePhaseChanged : IGameEvent<EventGamePhaseChanged> {

  static EventGamePhaseChanged IGameEvent<EventGamePhaseChanged>.FromAllocated(nint ptr) => new EventGamePhaseChangedImpl(ptr, true);

  static EventGamePhaseChanged IGameEvent<EventGamePhaseChanged>.FromExternal(nint ptr) => new EventGamePhaseChangedImpl(ptr, false);

  static string IGameEvent<EventGamePhaseChanged>.GetName() => "game_phase_changed";

  static uint IGameEvent<EventGamePhaseChanged>.GetHash() => 0x9FBE9554u;
  /// <summary>
  /// type: short
  /// </summary>
  short NewPhase { get; set; }

}
