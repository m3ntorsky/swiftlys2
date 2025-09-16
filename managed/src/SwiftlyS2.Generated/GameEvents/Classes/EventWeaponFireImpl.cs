using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "weapon_fire"
/// </summary>
internal class EventWeaponFireImpl : GameEvent<EventWeaponFire>, EventWeaponFire
{

  public EventWeaponFireImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  // weapon name used
  public string Weapon
  { get => GetString("weapon"); set => SetString("weapon", value); }

  // is weapon silenced
  public bool Silenced
  { get => GetBool("silenced"); set => SetBool("silenced", value); }
}
