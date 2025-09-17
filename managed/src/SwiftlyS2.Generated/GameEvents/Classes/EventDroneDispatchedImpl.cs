using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "drone_dispatched"
/// </summary>
internal class EventDroneDispatchedImpl : TypedGameEvent<EventDroneDispatched>, EventDroneDispatched
{

  public EventDroneDispatchedImpl(IGameEvent accessor) : base(accessor)
  {
  }

  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }

  public short Priority
  { get => (short)Accessor.GetInt32("priority"); set => Accessor.SetInt32("priority", value); }

  public short DroneDispatched
  { get => (short)Accessor.GetInt32("drone_dispatched"); set => Accessor.SetInt32("drone_dispatched", value); }
}
