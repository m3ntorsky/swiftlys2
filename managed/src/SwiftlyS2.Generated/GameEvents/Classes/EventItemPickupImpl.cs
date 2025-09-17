using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "item_pickup"
/// </summary>
internal class EventItemPickupImpl : TypedGameEvent<EventItemPickup>, EventItemPickup
{

  public EventItemPickupImpl(IGameEvent accessor) : base(accessor)
  {
  }

  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }

  // either a weapon such as 'tmp' or 'hegrenade', or an item such as 'nvgs'
  public string Item
  { get => Accessor.GetString("item"); set => Accessor.SetString("item", value); }

  public bool Silent
  { get => Accessor.GetBool("silent"); set => Accessor.SetBool("silent", value); }

  public int DefIndex
  { get => Accessor.GetInt32("defindex"); set => Accessor.SetInt32("defindex", value); }
}
