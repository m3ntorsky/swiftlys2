using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "door_close"
/// </summary>
internal class EventDoorCloseImpl : GameEvent<EventDoorClose>, EventDoorClose
{

  public EventDoorCloseImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // Who closed the door
  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  // Is the door a checkpoint door
  public bool Checkpoint
  { get => GetBool("checkpoint"); set => SetBool("checkpoint", value); }
}
