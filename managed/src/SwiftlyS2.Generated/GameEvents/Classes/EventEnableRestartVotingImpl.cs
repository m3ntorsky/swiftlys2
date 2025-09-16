using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "enable_restart_voting"
/// </summary>
internal class EventEnableRestartVotingImpl : GameEvent<EventEnableRestartVoting>, EventEnableRestartVoting
{

  public EventEnableRestartVotingImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public bool Enable
  { get => GetBool("enable"); set => SetBool("enable", value); }
}
