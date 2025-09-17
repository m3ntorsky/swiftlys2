using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "survival_no_respawns_warning"
/// </summary>
public interface EventSurvivalNoRespawnsWarning : ITypedGameEvent<EventSurvivalNoRespawnsWarning> {

  static EventSurvivalNoRespawnsWarning ITypedGameEvent<EventSurvivalNoRespawnsWarning>.Wrap(IGameEvent accessor) => new EventSurvivalNoRespawnsWarningImpl(accessor);

  static string ITypedGameEvent<EventSurvivalNoRespawnsWarning>.GetName() => "survival_no_respawns_warning";

  static uint ITypedGameEvent<EventSurvivalNoRespawnsWarning>.GetHash() => 0xE1C858A2u;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

}
