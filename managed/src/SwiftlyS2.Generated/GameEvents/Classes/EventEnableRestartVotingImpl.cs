using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "enable_restart_voting"
/// </summary>
internal class EventEnableRestartVotingImpl : TypedGameEvent<EventEnableRestartVoting>, EventEnableRestartVoting
{


  public bool Enable
  { get => Accessor.GetBool("enable"); set => Accessor.SetBool("enable", value); }
}
