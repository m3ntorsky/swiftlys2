using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "defuser_dropped"
/// </summary>
internal class EventDefuserDroppedImpl : GameEvent<EventDefuserDropped>, EventDefuserDropped
{

  public EventDefuserDroppedImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // defuser's entity ID
  public int EntityID
  { get => GetInt("entityid"); set => SetInt("entityid", value); }
}
