using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "drone_dispatched"
/// </summary>
public interface EventDroneDispatched : ITypedGameEvent<EventDroneDispatched> {

  static EventDroneDispatched ITypedGameEvent<EventDroneDispatched>.Wrap(IGameEvent accessor) => new EventDroneDispatchedImpl(accessor);

  static string ITypedGameEvent<EventDroneDispatched>.GetName() => "drone_dispatched";

  static uint ITypedGameEvent<EventDroneDispatched>.GetHash() => 0x4491A405u;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// type: short
  /// </summary>
  short Priority { get; set; }

  /// <summary>
  /// type: short
  /// </summary>
  short DroneDispatched { get; set; }

}
