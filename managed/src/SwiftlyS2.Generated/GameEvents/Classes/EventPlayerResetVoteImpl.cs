using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "player_reset_vote"
/// </summary>
internal class EventPlayerResetVoteImpl : GameEvent<EventPlayerResetVote>, EventPlayerResetVote
{

  public EventPlayerResetVoteImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  public bool Vote
  { get => GetBool("vote"); set => SetBool("vote", value); }
}
