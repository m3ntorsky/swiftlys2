using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "survival_no_respawns_final"
/// </summary>
public interface EventSurvivalNoRespawnsFinal : ITypedGameEvent<EventSurvivalNoRespawnsFinal> {

  static EventSurvivalNoRespawnsFinal ITypedGameEvent<EventSurvivalNoRespawnsFinal>.Wrap(IGameEvent accessor) => new EventSurvivalNoRespawnsFinalImpl(accessor);

  static string ITypedGameEvent<EventSurvivalNoRespawnsFinal>.GetName() => "survival_no_respawns_final";

  static uint ITypedGameEvent<EventSurvivalNoRespawnsFinal>.GetHash() => 0xE88046CAu;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

}
