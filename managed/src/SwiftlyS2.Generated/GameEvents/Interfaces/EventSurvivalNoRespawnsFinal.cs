using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "survival_no_respawns_final"
/// </summary>
public interface EventSurvivalNoRespawnsFinal : IGameEvent<EventSurvivalNoRespawnsFinal> {

  static EventSurvivalNoRespawnsFinal IGameEvent<EventSurvivalNoRespawnsFinal>.FromAllocated(nint ptr) => new EventSurvivalNoRespawnsFinalImpl(ptr, true);

  static EventSurvivalNoRespawnsFinal IGameEvent<EventSurvivalNoRespawnsFinal>.FromExternal(nint ptr) => new EventSurvivalNoRespawnsFinalImpl(ptr, false);

  static string IGameEvent<EventSurvivalNoRespawnsFinal>.GetName() => "survival_no_respawns_final";

  static uint IGameEvent<EventSurvivalNoRespawnsFinal>.GetHash() => 0xE88046CAu;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

}
