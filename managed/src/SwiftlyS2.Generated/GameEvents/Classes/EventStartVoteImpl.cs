using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "start_vote"
/// </summary>
internal class EventStartVoteImpl : GameEvent<EventStartVote>, EventStartVote
{

  public EventStartVoteImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  public byte Type
  { get => (byte)GetInt("type"); set => SetInt("type", value); }

  public short VoteParameter
  { get => (short)GetInt("vote_parameter"); set => SetInt("vote_parameter", value); }
}
