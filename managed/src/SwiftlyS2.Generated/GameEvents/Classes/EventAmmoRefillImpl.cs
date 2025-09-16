using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "ammo_refill"
/// </summary>
internal class EventAmmoRefillImpl : GameEvent<EventAmmoRefill>, EventAmmoRefill
{

  public EventAmmoRefillImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  public bool Success
  { get => GetBool("success"); set => SetBool("success", value); }
}
