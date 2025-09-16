using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "item_pickup_slerp"
/// </summary>
internal class EventItemPickupSlerpImpl : GameEvent<EventItemPickupSlerp>, EventItemPickupSlerp
{

  public EventItemPickupSlerpImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  public short Index
  { get => (short)GetInt("index"); set => SetInt("index", value); }

  public short Behavior
  { get => (short)GetInt("behavior"); set => SetInt("behavior", value); }
}
