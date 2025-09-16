using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "hltv_replay"
/// </summary>
internal class EventHltvReplayImpl : GameEvent<EventHltvReplay>, EventHltvReplay
{

  public EventHltvReplayImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // number of seconds in killer replay delay
  public int Delay
  { get => GetInt("delay"); set => SetInt("delay", value); }

  // reason for replay	(ReplayEventType_t)
  public int Reason
  { get => GetInt("reason"); set => SetInt("reason", value); }
}
