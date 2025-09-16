using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "cs_round_start_beep"
/// </summary>
internal class EventCsRoundStartBeepImpl : GameEvent<EventCsRoundStartBeep>, EventCsRoundStartBeep
{

  public EventCsRoundStartBeepImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }
}
