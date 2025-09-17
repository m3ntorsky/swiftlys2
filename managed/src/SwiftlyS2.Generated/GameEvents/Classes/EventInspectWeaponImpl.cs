using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "inspect_weapon"
/// </summary>
internal class EventInspectWeaponImpl : TypedGameEvent<EventInspectWeapon>, EventInspectWeapon
{


  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }
}
