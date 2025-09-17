using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "jointeam_failed"
/// </summary>
public interface EventJointeamFailed : ITypedGameEvent<EventJointeamFailed> {

  static EventJointeamFailed ITypedGameEvent<EventJointeamFailed>.Create() => new EventJointeamFailedImpl();

  static string ITypedGameEvent<EventJointeamFailed>.GetName() => "jointeam_failed";

  static uint ITypedGameEvent<EventJointeamFailed>.GetHash() => 0xCAAD4F84u;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// 0 = team_full
  /// <br/>
  /// type: byte
  /// </summary>
  byte Reason { get; set; }

}
