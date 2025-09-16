using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "hltv_replay_status"
/// </summary>
internal class EventHltvReplayStatusImpl : GameEvent<EventHltvReplayStatus>, EventHltvReplayStatus
{

  public EventHltvReplayStatusImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // reason for hltv replay status change ()
  public int Reason
  { get => GetInt("reason"); set => SetInt("reason", value); }
}
