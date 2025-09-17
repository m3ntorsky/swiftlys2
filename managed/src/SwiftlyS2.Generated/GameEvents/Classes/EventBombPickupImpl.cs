using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "bomb_pickup"
/// </summary>
internal class EventBombPickupImpl : TypedGameEvent<EventBombPickup>, EventBombPickup
{


  // player pawn who picked up the bomb
  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }
}
