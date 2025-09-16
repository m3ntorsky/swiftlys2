using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "weapon_fire_on_empty"
/// </summary>
internal class EventWeaponFireOnEmptyImpl : GameEvent<EventWeaponFireOnEmpty>, EventWeaponFireOnEmpty
{

  public EventWeaponFireOnEmptyImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  // weapon name used
  public string Weapon
  { get => GetString("weapon"); set => SetString("weapon", value); }
}
