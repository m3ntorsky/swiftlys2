using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "vote_failed"
/// </summary>
public interface EventVoteFailed : ITypedGameEvent<EventVoteFailed> {

  static EventVoteFailed ITypedGameEvent<EventVoteFailed>.Wrap(IGameEvent accessor) => new EventVoteFailedImpl(accessor);

  static string ITypedGameEvent<EventVoteFailed>.GetName() => "vote_failed";

  static uint ITypedGameEvent<EventVoteFailed>.GetHash() => 0xCD2BE01Fu;
  /// <summary>
  /// type: byte
  /// </summary>
  byte Team { get; set; }

}
