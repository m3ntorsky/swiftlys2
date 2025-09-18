using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "survival_teammate_respawn"
/// </summary>
public interface EventSurvivalTeammateRespawn : IGameEvent<EventSurvivalTeammateRespawn> {

  static EventSurvivalTeammateRespawn IGameEvent<EventSurvivalTeammateRespawn>.Create() => new EventSurvivalTeammateRespawnImpl();

  static string IGameEvent<EventSurvivalTeammateRespawn>.GetName() => "survival_teammate_respawn";

  static uint IGameEvent<EventSurvivalTeammateRespawn>.GetHash() => 0x558ADEEBu;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserIdController { get; }

  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerPawn UserIdPawn { get; }

  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  int UserId { get; set; }

}
