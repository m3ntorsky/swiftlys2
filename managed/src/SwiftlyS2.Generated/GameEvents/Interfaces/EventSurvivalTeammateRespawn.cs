using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "survival_teammate_respawn"
/// </summary>
public interface EventSurvivalTeammateRespawn : ITypedGameEvent<EventSurvivalTeammateRespawn> {

  static EventSurvivalTeammateRespawn ITypedGameEvent<EventSurvivalTeammateRespawn>.Wrap(IGameEvent accessor) => new EventSurvivalTeammateRespawnImpl(accessor);

  static string ITypedGameEvent<EventSurvivalTeammateRespawn>.GetName() => "survival_teammate_respawn";

  static uint ITypedGameEvent<EventSurvivalTeammateRespawn>.GetHash() => 0x558ADEEBu;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

}
