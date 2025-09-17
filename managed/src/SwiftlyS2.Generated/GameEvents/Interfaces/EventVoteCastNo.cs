using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "vote_cast_no"
/// </summary>
public interface EventVoteCastNo : ITypedGameEvent<EventVoteCastNo> {

  static EventVoteCastNo ITypedGameEvent<EventVoteCastNo>.Wrap(IGameEvent accessor) => new EventVoteCastNoImpl(accessor);

  static string ITypedGameEvent<EventVoteCastNo>.GetName() => "vote_cast_no";

  static uint ITypedGameEvent<EventVoteCastNo>.GetHash() => 0x73639B1Du;
  /// <summary>
  /// type: byte
  /// </summary>
  byte Team { get; set; }

  /// <summary>
  /// entity id of the voter
  /// <br/>
  /// type: long
  /// </summary>
  int EntityID { get; set; }

}
