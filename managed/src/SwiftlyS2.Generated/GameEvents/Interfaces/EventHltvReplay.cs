using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "hltv_replay"
/// </summary>
public interface EventHltvReplay : ITypedGameEvent<EventHltvReplay> {

  static EventHltvReplay ITypedGameEvent<EventHltvReplay>.Wrap(IGameEvent accessor) => new EventHltvReplayImpl(accessor);

  static string ITypedGameEvent<EventHltvReplay>.GetName() => "hltv_replay";

  static uint ITypedGameEvent<EventHltvReplay>.GetHash() => 0xC117A4EBu;
  /// <summary>
  /// number of seconds in killer replay delay
  /// <br/>
  /// type: long
  /// </summary>
  int Delay { get; set; }

  /// <summary>
  /// reason for replay	(ReplayEventType_t)
  /// <br/>
  /// type: long
  /// </summary>
  int Reason { get; set; }

}
