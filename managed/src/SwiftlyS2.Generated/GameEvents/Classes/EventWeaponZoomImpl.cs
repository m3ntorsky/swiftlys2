using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "weapon_zoom"
/// </summary>
internal class EventWeaponZoomImpl : GameEvent<EventWeaponZoom>, EventWeaponZoom
{


  public CCSPlayerController UserIdController
  { get => Accessor.GetPlayerController("userid"); }

  public CCSPlayerPawn UserIdPawn
  { get => Accessor.GetPlayerPawn("userid"); }

  public int UserId
  { get => Accessor.GetInt32("userid"); set => Accessor.SetInt32("userid", value); }
}
