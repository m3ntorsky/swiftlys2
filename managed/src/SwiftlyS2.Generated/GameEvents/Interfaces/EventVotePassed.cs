using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "vote_passed"
/// </summary>
public interface EventVotePassed : ITypedGameEvent<EventVotePassed> {

  static EventVotePassed ITypedGameEvent<EventVotePassed>.Wrap(IGameEvent accessor) => new EventVotePassedImpl(accessor);

  static string ITypedGameEvent<EventVotePassed>.GetName() => "vote_passed";

  static uint ITypedGameEvent<EventVotePassed>.GetHash() => 0x9B90008Eu;
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
