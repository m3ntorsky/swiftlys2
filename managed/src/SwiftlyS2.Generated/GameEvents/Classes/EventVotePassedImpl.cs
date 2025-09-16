using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "vote_passed"
/// </summary>
internal class EventVotePassedImpl : GameEvent<EventVotePassed>, EventVotePassed
{

  public EventVotePassedImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public string Details
  { get => GetString("details"); set => SetString("details", value); }

  public string Param1
  { get => GetString("param1"); set => SetString("param1", value); }

  public byte Team
  { get => (byte)GetInt("team"); set => SetInt("team", value); }
}
