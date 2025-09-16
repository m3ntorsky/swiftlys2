using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "vote_cast_no"
/// </summary>
internal class EventVoteCastNoImpl : GameEvent<EventVoteCastNo>, EventVoteCastNo
{

  public EventVoteCastNoImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public byte Team
  { get => (byte)GetInt("team"); set => SetInt("team", value); }

  // entity id of the voter
  public int EntityID
  { get => GetInt("entityid"); set => SetInt("entityid", value); }
}
