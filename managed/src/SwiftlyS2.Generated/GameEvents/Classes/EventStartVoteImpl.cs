using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "start_vote"
/// </summary>
internal class EventStartVoteImpl : TypedGameEvent<EventStartVote>, EventStartVote
{


  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }

  public byte Type
  { get => (byte)Accessor.GetInt32("type"); set => Accessor.SetInt32("type", value); }

  public short VoteParameter
  { get => (short)Accessor.GetInt32("vote_parameter"); set => Accessor.SetInt32("vote_parameter", value); }
}
