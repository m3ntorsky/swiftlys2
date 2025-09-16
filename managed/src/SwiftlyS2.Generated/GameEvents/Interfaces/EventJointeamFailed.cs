using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "jointeam_failed"
/// </summary>
public interface EventJointeamFailed : IGameEvent<EventJointeamFailed> {

  static EventJointeamFailed IGameEvent<EventJointeamFailed>.FromAllocated(nint ptr) => new EventJointeamFailedImpl(ptr, true);

  static EventJointeamFailed IGameEvent<EventJointeamFailed>.FromExternal(nint ptr) => new EventJointeamFailedImpl(ptr, false);

  static string IGameEvent<EventJointeamFailed>.GetName() => "jointeam_failed";

  static uint IGameEvent<EventJointeamFailed>.GetHash() => 0xCAAD4F84u;
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
