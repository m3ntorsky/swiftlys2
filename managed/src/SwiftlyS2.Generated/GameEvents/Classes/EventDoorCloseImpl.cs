using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "door_close"
/// </summary>
internal class EventDoorCloseImpl : TypedGameEvent<EventDoorClose>, EventDoorClose
{

  public EventDoorCloseImpl(IGameEvent accessor) : base(accessor)
  {
  }

  // Who closed the door
  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }

  // Is the door a checkpoint door
  public bool Checkpoint
  { get => Accessor.GetBool("checkpoint"); set => Accessor.SetBool("checkpoint", value); }
}
