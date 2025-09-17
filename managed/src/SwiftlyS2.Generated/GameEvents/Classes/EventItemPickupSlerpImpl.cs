using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "item_pickup_slerp"
/// </summary>
internal class EventItemPickupSlerpImpl : TypedGameEvent<EventItemPickupSlerp>, EventItemPickupSlerp
{


  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }

  public short Index
  { get => (short)Accessor.GetInt32("index"); set => Accessor.SetInt32("index", value); }

  public short Behavior
  { get => (short)Accessor.GetInt32("behavior"); set => Accessor.SetInt32("behavior", value); }
}
