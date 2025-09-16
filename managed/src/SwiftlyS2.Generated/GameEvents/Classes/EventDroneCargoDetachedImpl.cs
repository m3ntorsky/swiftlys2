using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "drone_cargo_detached"
/// </summary>
internal class EventDroneCargoDetachedImpl : GameEvent<EventDroneCargoDetached>, EventDroneCargoDetached
{

  public EventDroneCargoDetachedImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  public short Cargo
  { get => (short)GetInt("cargo"); set => SetInt("cargo", value); }

  public bool Delivered
  { get => GetBool("delivered"); set => SetBool("delivered", value); }
}
