using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "vote_changed"
/// </summary>
public interface EventVoteChanged : IGameEvent<EventVoteChanged> {

  static EventVoteChanged IGameEvent<EventVoteChanged>.FromAllocated(nint ptr) => new EventVoteChangedImpl(ptr, true);

  static EventVoteChanged IGameEvent<EventVoteChanged>.FromExternal(nint ptr) => new EventVoteChangedImpl(ptr, false);

  static string IGameEvent<EventVoteChanged>.GetName() => "vote_changed";

  static uint IGameEvent<EventVoteChanged>.GetHash() => 0xA69CF8EAu;
  /// <summary>
  /// type: byte
  /// </summary>
  byte YesVotes { get; set; }

  /// <summary>
  /// type: byte
  /// </summary>
  byte NoVotes { get; set; }

  /// <summary>
  /// type: byte
  /// </summary>
  byte PotentialVotes { get; set; }

}
