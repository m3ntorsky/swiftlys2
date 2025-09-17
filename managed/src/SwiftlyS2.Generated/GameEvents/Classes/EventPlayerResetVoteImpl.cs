using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "player_reset_vote"
/// </summary>
internal class EventPlayerResetVoteImpl : TypedGameEvent<EventPlayerResetVote>, EventPlayerResetVote
{

  public EventPlayerResetVoteImpl(IGameEvent accessor) : base(accessor)
  {
  }

  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }

  public bool Vote
  { get => Accessor.GetBool("vote"); set => Accessor.SetBool("vote", value); }
}
