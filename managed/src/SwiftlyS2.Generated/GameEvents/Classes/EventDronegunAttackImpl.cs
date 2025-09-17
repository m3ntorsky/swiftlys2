using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "dronegun_attack"
/// </summary>
internal class EventDronegunAttackImpl : TypedGameEvent<EventDronegunAttack>, EventDronegunAttack
{


  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }
}
