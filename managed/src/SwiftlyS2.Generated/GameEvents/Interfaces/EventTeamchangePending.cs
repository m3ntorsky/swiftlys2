using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "teamchange_pending"
/// </summary>
public interface EventTeamchangePending : IGameEvent<EventTeamchangePending> {

  static EventTeamchangePending IGameEvent<EventTeamchangePending>.FromAllocated(nint ptr) => new EventTeamchangePendingImpl(ptr, true);

  static EventTeamchangePending IGameEvent<EventTeamchangePending>.FromExternal(nint ptr) => new EventTeamchangePendingImpl(ptr, false);

  static string IGameEvent<EventTeamchangePending>.GetName() => "teamchange_pending";

  static uint IGameEvent<EventTeamchangePending>.GetHash() => 0x53F97450u;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// type: byte
  /// </summary>
  byte ToTeam { get; set; }

}
