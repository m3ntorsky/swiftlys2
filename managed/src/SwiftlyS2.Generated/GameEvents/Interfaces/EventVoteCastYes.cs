using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "vote_cast_yes"
/// </summary>
public interface EventVoteCastYes : ITypedGameEvent<EventVoteCastYes> {

  static EventVoteCastYes ITypedGameEvent<EventVoteCastYes>.Wrap(IGameEvent accessor) => new EventVoteCastYesImpl(accessor);

  static string ITypedGameEvent<EventVoteCastYes>.GetName() => "vote_cast_yes";

  static uint ITypedGameEvent<EventVoteCastYes>.GetHash() => 0xC6314219u;
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
