using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "drone_cargo_detached"
/// </summary>
public interface EventDroneCargoDetached : ITypedGameEvent<EventDroneCargoDetached> {

  static EventDroneCargoDetached ITypedGameEvent<EventDroneCargoDetached>.Create() => new EventDroneCargoDetachedImpl();

  static string ITypedGameEvent<EventDroneCargoDetached>.GetName() => "drone_cargo_detached";

  static uint ITypedGameEvent<EventDroneCargoDetached>.GetHash() => 0x958BD369u;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// type: short
  /// </summary>
  short Cargo { get; set; }

  /// <summary>
  /// type: bool
  /// </summary>
  bool Delivered { get; set; }

}
