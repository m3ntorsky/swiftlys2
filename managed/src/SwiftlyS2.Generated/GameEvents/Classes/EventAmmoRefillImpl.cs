using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "ammo_refill"
/// </summary>
internal class EventAmmoRefillImpl : TypedGameEvent<EventAmmoRefill>, EventAmmoRefill
{


  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }

  public bool Success
  { get => Accessor.GetBool("success"); set => Accessor.SetBool("success", value); }
}
