using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "vote_changed"
/// </summary>
internal class EventVoteChangedImpl : TypedGameEvent<EventVoteChanged>, EventVoteChanged
{


  public byte YesVotes
  { get => (byte)Accessor.GetInt32("yesVotes"); set => Accessor.SetInt32("yesVotes", value); }

  public byte NoVotes
  { get => (byte)Accessor.GetInt32("noVotes"); set => Accessor.SetInt32("noVotes", value); }

  public byte PotentialVotes
  { get => (byte)Accessor.GetInt32("potentialVotes"); set => Accessor.SetInt32("potentialVotes", value); }
}
