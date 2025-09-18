using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "player_reset_vote"
/// </summary>
public interface EventPlayerResetVote : IGameEvent<EventPlayerResetVote> {

  static EventPlayerResetVote IGameEvent<EventPlayerResetVote>.Create() => new EventPlayerResetVoteImpl();

  static string IGameEvent<EventPlayerResetVote>.GetName() => "player_reset_vote";

  static uint IGameEvent<EventPlayerResetVote>.GetHash() => 0x86ED6215u;
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

  /// <summary>
  /// type: bool
  /// </summary>
  bool Vote { get; set; }

}
