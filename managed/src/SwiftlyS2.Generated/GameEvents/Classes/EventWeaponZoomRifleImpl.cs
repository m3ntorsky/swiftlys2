using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "weapon_zoom_rifle"
/// </summary>
internal class EventWeaponZoomRifleImpl : TypedGameEvent<EventWeaponZoomRifle>, EventWeaponZoomRifle
{


  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }
}
