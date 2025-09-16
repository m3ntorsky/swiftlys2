using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "door_moving"
/// </summary>
internal class EventDoorMovingImpl : GameEvent<EventDoorMoving>, EventDoorMoving
{

  public EventDoorMovingImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  public int EntIndex
  { get => GetInt("entindex"); set => SetInt("entindex", value); }
}
