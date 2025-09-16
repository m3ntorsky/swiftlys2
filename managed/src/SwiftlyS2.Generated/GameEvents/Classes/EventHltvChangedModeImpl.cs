using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "hltv_changed_mode"
/// </summary>
internal class EventHltvChangedModeImpl : GameEvent<EventHltvChangedMode>, EventHltvChangedMode
{

  public EventHltvChangedModeImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public int OldMode
  { get => GetInt("oldmode"); set => SetInt("oldmode", value); }

  public int NewMode
  { get => GetInt("newmode"); set => SetInt("newmode", value); }

  public int ObsTarget
  { get => GetInt("obs_target"); set => SetInt("obs_target", value); }
}
