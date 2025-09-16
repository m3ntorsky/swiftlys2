using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "vote_passed"
/// </summary>
public interface EventVotePassed : IGameEvent<EventVotePassed> {

  static EventVotePassed IGameEvent<EventVotePassed>.FromAllocated(nint ptr) => new EventVotePassedImpl(ptr, true);

  static EventVotePassed IGameEvent<EventVotePassed>.FromExternal(nint ptr) => new EventVotePassedImpl(ptr, false);

  static string IGameEvent<EventVotePassed>.GetName() => "vote_passed";

  static uint IGameEvent<EventVotePassed>.GetHash() => 0x9B90008Eu;
  /// <summary>
  /// type: string
  /// </summary>
  string Details { get; set; }

  /// <summary>
  /// type: string
  /// </summary>
  string Param1 { get; set; }

  /// <summary>
  /// type: byte
  /// </summary>
  byte Team { get; set; }

}
