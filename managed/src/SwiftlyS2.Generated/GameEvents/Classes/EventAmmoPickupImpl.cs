using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "ammo_pickup"
/// </summary>
internal class EventAmmoPickupImpl : TypedGameEvent<EventAmmoPickup>, EventAmmoPickup
{

  public EventAmmoPickupImpl(IGameEvent accessor) : base(accessor)
  {
  }

  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }

  // either a weapon such as 'tmp' or 'hegrenade', or an item such as 'nvgs'
  public string Item
  { get => Accessor.GetString("item"); set => Accessor.SetString("item", value); }

  // the weapon entindex
  public int Index
  { get => Accessor.GetInt32("index"); set => Accessor.SetInt32("index", value); }
}
