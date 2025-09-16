using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "nextlevel_changed"
/// a game event, name may be 32 characters long
/// </summary>
internal class EventNextlevelChangedImpl : GameEvent<EventNextlevelChanged>, EventNextlevelChanged
{

  public EventNextlevelChangedImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public string NextLevel
  { get => GetString("nextlevel"); set => SetString("nextlevel", value); }

  public string MapGroup
  { get => GetString("mapgroup"); set => SetString("mapgroup", value); }

  public string SkirmishMode
  { get => GetString("skirmishmode"); set => SetString("skirmishmode", value); }
}
