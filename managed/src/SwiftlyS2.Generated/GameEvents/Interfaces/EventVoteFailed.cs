using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "vote_failed"
/// </summary>
public interface EventVoteFailed : IGameEvent<EventVoteFailed> {

  static EventVoteFailed IGameEvent<EventVoteFailed>.Create() => new EventVoteFailedImpl();

  static string IGameEvent<EventVoteFailed>.GetName() => "vote_failed";

  static uint IGameEvent<EventVoteFailed>.GetHash() => 0xCD2BE01Fu;
  /// <summary>
  /// type: byte
  /// </summary>
  byte Team { get; set; }

}
