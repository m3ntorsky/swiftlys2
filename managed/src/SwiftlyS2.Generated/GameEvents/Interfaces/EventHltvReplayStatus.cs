using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "hltv_replay_status"
/// </summary>
public interface EventHltvReplayStatus : ITypedGameEvent<EventHltvReplayStatus> {

  static EventHltvReplayStatus ITypedGameEvent<EventHltvReplayStatus>.Create() => new EventHltvReplayStatusImpl();

  static string ITypedGameEvent<EventHltvReplayStatus>.GetName() => "hltv_replay_status";

  static uint ITypedGameEvent<EventHltvReplayStatus>.GetHash() => 0x262D2D46u;
  /// <summary>
  /// reason for hltv replay status change ()
  /// <br/>
  /// type: long
  /// </summary>
  int Reason { get; set; }

}
