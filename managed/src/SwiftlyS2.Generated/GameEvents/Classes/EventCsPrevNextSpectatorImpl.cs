using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "cs_prev_next_spectator"
/// </summary>
internal class EventCsPrevNextSpectatorImpl : GameEvent<EventCsPrevNextSpectator>, EventCsPrevNextSpectator
{

  public EventCsPrevNextSpectatorImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public bool Next
  { get => GetBool("next"); set => SetBool("next", value); }
}
