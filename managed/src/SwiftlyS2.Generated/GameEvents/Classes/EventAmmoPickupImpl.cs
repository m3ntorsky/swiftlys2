using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "ammo_pickup"
/// </summary>
internal class EventAmmoPickupImpl : GameEvent<EventAmmoPickup>, EventAmmoPickup
{

  public EventAmmoPickupImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  // either a weapon such as 'tmp' or 'hegrenade', or an item such as 'nvgs'
  public string Item
  { get => GetString("item"); set => SetString("item", value); }

  // the weapon entindex
  public int Index
  { get => GetInt("index"); set => SetInt("index", value); }
}
