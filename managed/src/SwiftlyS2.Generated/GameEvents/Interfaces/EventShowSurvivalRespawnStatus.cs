using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "show_survival_respawn_status"
/// </summary>
public interface EventShowSurvivalRespawnStatus : ITypedGameEvent<EventShowSurvivalRespawnStatus> {

  static EventShowSurvivalRespawnStatus ITypedGameEvent<EventShowSurvivalRespawnStatus>.Create() => new EventShowSurvivalRespawnStatusImpl();

  static string ITypedGameEvent<EventShowSurvivalRespawnStatus>.GetName() => "show_survival_respawn_status";

  static uint ITypedGameEvent<EventShowSurvivalRespawnStatus>.GetHash() => 0xAF60FAAFu;
  /// <summary>
  /// type: string
  /// </summary>
  string LocToken { get; set; }

  /// <summary>
  /// type: long
  /// </summary>
  int Duration { get; set; }

  /// <summary>
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

}
