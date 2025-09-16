using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "physgun_pickup"
/// </summary>
internal class EventPhysgunPickupImpl : GameEvent<EventPhysgunPickup>, EventPhysgunPickup
{

  public EventPhysgunPickupImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // entity picked up
  public nint Target
  { get => GetPtr("target"); set => SetPtr("target", value); }
}
