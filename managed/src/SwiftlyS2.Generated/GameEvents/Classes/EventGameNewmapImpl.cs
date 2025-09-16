using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "game_newmap"
/// send when new map is completely loaded
/// </summary>
internal class EventGameNewmapImpl : GameEvent<EventGameNewmap>, EventGameNewmap
{

  public EventGameNewmapImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // map name
  public string MapName
  { get => GetString("mapname"); set => SetString("mapname", value); }

  // true if this is a transition from one map to another
  public bool Transition
  { get => GetBool("transition"); set => SetBool("transition", value); }
}
