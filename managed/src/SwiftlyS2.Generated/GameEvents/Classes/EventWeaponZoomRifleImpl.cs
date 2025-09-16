using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "weapon_zoom_rifle"
/// </summary>
internal class EventWeaponZoomRifleImpl : GameEvent<EventWeaponZoomRifle>, EventWeaponZoomRifle
{

  public EventWeaponZoomRifleImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }
}
