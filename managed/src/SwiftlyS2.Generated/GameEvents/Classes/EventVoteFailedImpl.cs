using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "vote_failed"
/// </summary>
internal class EventVoteFailedImpl : GameEvent<EventVoteFailed>, EventVoteFailed
{

  public EventVoteFailedImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public byte Team
  { get => (byte)GetInt("team"); set => SetInt("team", value); }
}
