using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "player_ping_stop"
/// </summary>
public interface EventPlayerPingStop : ITypedGameEvent<EventPlayerPingStop> {

  static EventPlayerPingStop ITypedGameEvent<EventPlayerPingStop>.Wrap(IGameEvent accessor) => new EventPlayerPingStopImpl(accessor);

  static string ITypedGameEvent<EventPlayerPingStop>.GetName() => "player_ping_stop";

  static uint ITypedGameEvent<EventPlayerPingStop>.GetHash() => 0x5C803792u;
  /// <summary>
  /// type: short
  /// </summary>
  short EntityID { get; set; }

}
