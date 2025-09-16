using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "drone_dispatched"
/// </summary>
internal class EventDroneDispatchedImpl : GameEvent<EventDroneDispatched>, EventDroneDispatched
{

  public EventDroneDispatchedImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  public short Priority
  { get => (short)GetInt("priority"); set => SetInt("priority", value); }

  public short DroneDispatched
  { get => (short)GetInt("drone_dispatched"); set => SetInt("drone_dispatched", value); }
}
