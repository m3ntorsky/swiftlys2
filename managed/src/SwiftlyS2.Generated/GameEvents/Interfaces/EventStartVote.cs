using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "start_vote"
/// </summary>
public interface EventStartVote : ITypedGameEvent<EventStartVote> {

  static EventStartVote ITypedGameEvent<EventStartVote>.Create() => new EventStartVoteImpl();

  static string ITypedGameEvent<EventStartVote>.GetName() => "start_vote";

  static uint ITypedGameEvent<EventStartVote>.GetHash() => 0x637C08B4u;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// type: byte
  /// </summary>
  byte Type { get; set; }

  /// <summary>
  /// type: short
  /// </summary>
  short VoteParameter { get; set; }

}
