using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "vote_changed"
/// </summary>
internal class EventVoteChangedImpl : GameEvent<EventVoteChanged>, EventVoteChanged
{

  public EventVoteChangedImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public byte YesVotes
  { get => (byte)GetInt("yesVotes"); set => SetInt("yesVotes", value); }

  public byte NoVotes
  { get => (byte)GetInt("noVotes"); set => SetInt("noVotes", value); }

  public byte PotentialVotes
  { get => (byte)GetInt("potentialVotes"); set => SetInt("potentialVotes", value); }
}
