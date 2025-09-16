using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "defuser_pickup"
/// </summary>
internal class EventDefuserPickupImpl : GameEvent<EventDefuserPickup>, EventDefuserPickup
{

  public EventDefuserPickupImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // defuser's entity ID
  public int EntityID
  { get => GetInt("entityid"); set => SetInt("entityid", value); }

  // player who picked up the defuser
  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }
}
