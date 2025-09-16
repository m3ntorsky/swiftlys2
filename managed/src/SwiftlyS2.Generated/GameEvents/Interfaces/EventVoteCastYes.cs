using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "vote_cast_yes"
/// </summary>
public interface EventVoteCastYes : IGameEvent<EventVoteCastYes> {

  static EventVoteCastYes IGameEvent<EventVoteCastYes>.FromAllocated(nint ptr) => new EventVoteCastYesImpl(ptr, true);

  static EventVoteCastYes IGameEvent<EventVoteCastYes>.FromExternal(nint ptr) => new EventVoteCastYesImpl(ptr, false);

  static string IGameEvent<EventVoteCastYes>.GetName() => "vote_cast_yes";

  static uint IGameEvent<EventVoteCastYes>.GetHash() => 0xC6314219u;
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
