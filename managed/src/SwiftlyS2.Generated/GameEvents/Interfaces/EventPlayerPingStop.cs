using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "player_ping_stop"
/// </summary>
public interface EventPlayerPingStop : IGameEvent<EventPlayerPingStop> {

  static EventPlayerPingStop IGameEvent<EventPlayerPingStop>.FromAllocated(nint ptr) => new EventPlayerPingStopImpl(ptr, true);

  static EventPlayerPingStop IGameEvent<EventPlayerPingStop>.FromExternal(nint ptr) => new EventPlayerPingStopImpl(ptr, false);

  static string IGameEvent<EventPlayerPingStop>.GetName() => "player_ping_stop";

  static uint IGameEvent<EventPlayerPingStop>.GetHash() => 0x5C803792u;
  /// <summary>
  /// type: short
  /// </summary>
  short EntityID { get; set; }

}
