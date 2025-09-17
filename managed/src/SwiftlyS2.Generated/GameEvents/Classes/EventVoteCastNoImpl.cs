using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "vote_cast_no"
/// </summary>
internal class EventVoteCastNoImpl : TypedGameEvent<EventVoteCastNo>, EventVoteCastNo
{


  public byte Team
  { get => (byte)Accessor.GetInt32("team"); set => Accessor.SetInt32("team", value); }

  // entity id of the voter
  public int EntityID
  { get => Accessor.GetInt32("entityid"); set => Accessor.SetInt32("entityid", value); }
}
