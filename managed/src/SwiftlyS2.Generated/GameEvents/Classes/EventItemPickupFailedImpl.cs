using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "item_pickup_failed"
/// </summary>
internal class EventItemPickupFailedImpl : GameEvent<EventItemPickupFailed>, EventItemPickupFailed
{

  public EventItemPickupFailedImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  public string Item
  { get => GetString("item"); set => SetString("item", value); }

  public short Reason
  { get => (short)GetInt("reason"); set => SetInt("reason", value); }

  public short Limit
  { get => (short)GetInt("limit"); set => SetInt("limit", value); }
}
