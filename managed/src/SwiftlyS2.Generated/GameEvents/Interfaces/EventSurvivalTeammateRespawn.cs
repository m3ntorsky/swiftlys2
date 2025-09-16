using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "survival_teammate_respawn"
/// </summary>
public interface EventSurvivalTeammateRespawn : IGameEvent<EventSurvivalTeammateRespawn> {

  static EventSurvivalTeammateRespawn IGameEvent<EventSurvivalTeammateRespawn>.FromAllocated(nint ptr) => new EventSurvivalTeammateRespawnImpl(ptr, true);

  static EventSurvivalTeammateRespawn IGameEvent<EventSurvivalTeammateRespawn>.FromExternal(nint ptr) => new EventSurvivalTeammateRespawnImpl(ptr, false);

  static string IGameEvent<EventSurvivalTeammateRespawn>.GetName() => "survival_teammate_respawn";

  static uint IGameEvent<EventSurvivalTeammateRespawn>.GetHash() => 0x558ADEEBu;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

}
