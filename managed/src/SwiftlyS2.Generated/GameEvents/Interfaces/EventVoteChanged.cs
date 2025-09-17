using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "vote_changed"
/// </summary>
public interface EventVoteChanged : ITypedGameEvent<EventVoteChanged> {

  static EventVoteChanged ITypedGameEvent<EventVoteChanged>.Create() => new EventVoteChangedImpl();

  static string ITypedGameEvent<EventVoteChanged>.GetName() => "vote_changed";

  static uint ITypedGameEvent<EventVoteChanged>.GetHash() => 0xA69CF8EAu;
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
