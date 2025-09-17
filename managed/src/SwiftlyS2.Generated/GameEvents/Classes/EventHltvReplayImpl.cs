using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "hltv_replay"
/// </summary>
internal class EventHltvReplayImpl : TypedGameEvent<EventHltvReplay>, EventHltvReplay
{

  public EventHltvReplayImpl(IGameEvent accessor) : base(accessor)
  {
  }

  // number of seconds in killer replay delay
  public int Delay
  { get => Accessor.GetInt32("delay"); set => Accessor.SetInt32("delay", value); }

  // reason for replay	(ReplayEventType_t)
  public int Reason
  { get => Accessor.GetInt32("reason"); set => Accessor.SetInt32("reason", value); }
}
