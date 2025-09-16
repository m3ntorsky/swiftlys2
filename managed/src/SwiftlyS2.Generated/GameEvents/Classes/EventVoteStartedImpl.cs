using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "vote_started"
/// </summary>
internal class EventVoteStartedImpl : GameEvent<EventVoteStarted>, EventVoteStarted
{

  public EventVoteStartedImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public string Issue
  { get => GetString("issue"); set => SetString("issue", value); }

  public string Param1
  { get => GetString("param1"); set => SetString("param1", value); }

  public string VoteData
  { get => GetString("votedata"); set => SetString("votedata", value); }

  public byte Team
  { get => (byte)GetInt("team"); set => SetInt("team", value); }

  // entity id of the player who initiated the vote
  public int Initiator
  { get => GetInt("initiator"); set => SetInt("initiator", value); }
}
