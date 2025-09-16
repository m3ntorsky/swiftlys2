using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "instructor_server_hint_stop"
/// destroys a server/map created hint
/// </summary>
internal class EventInstructorServerHintStopImpl : GameEvent<EventInstructorServerHintStop>, EventInstructorServerHintStop
{

  public EventInstructorServerHintStopImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // The hint to stop. Will stop ALL hints with this name
  public string HintName
  { get => GetString("hint_name"); set => SetString("hint_name", value); }

  // entity id of the env_instructor_hint that fired the event
  public int HintEntindex
  { get => GetInt("hint_entindex"); set => SetInt("hint_entindex", value); }
}
