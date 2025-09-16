using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "bomb_pickup"
/// </summary>
internal class EventBombPickupImpl : GameEvent<EventBombPickup>, EventBombPickup
{

  public EventBombPickupImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // player pawn who picked up the bomb
  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }
}
