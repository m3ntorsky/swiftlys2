using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "vote_started"
/// </summary>
public interface EventVoteStarted : IGameEvent<EventVoteStarted> {

  static EventVoteStarted IGameEvent<EventVoteStarted>.FromAllocated(nint ptr) => new EventVoteStartedImpl(ptr, true);

  static EventVoteStarted IGameEvent<EventVoteStarted>.FromExternal(nint ptr) => new EventVoteStartedImpl(ptr, false);

  static string IGameEvent<EventVoteStarted>.GetName() => "vote_started";

  static uint IGameEvent<EventVoteStarted>.GetHash() => 0xE0DFF70Fu;
  /// <summary>
  /// type: string
  /// </summary>
  string Issue { get; set; }

  /// <summary>
  /// type: string
  /// </summary>
  string Param1 { get; set; }

  /// <summary>
  /// type: string
  /// </summary>
  string VoteData { get; set; }

  /// <summary>
  /// type: byte
  /// </summary>
  byte Team { get; set; }

  /// <summary>
  /// entity id of the player who initiated the vote
  /// <br/>
  /// type: long
  /// </summary>
  int Initiator { get; set; }

}
