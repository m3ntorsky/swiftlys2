using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "drone_cargo_detached"
/// </summary>
public interface EventDroneCargoDetached : IGameEvent<EventDroneCargoDetached> {

  static EventDroneCargoDetached IGameEvent<EventDroneCargoDetached>.FromAllocated(nint ptr) => new EventDroneCargoDetachedImpl(ptr, true);

  static EventDroneCargoDetached IGameEvent<EventDroneCargoDetached>.FromExternal(nint ptr) => new EventDroneCargoDetachedImpl(ptr, false);

  static string IGameEvent<EventDroneCargoDetached>.GetName() => "drone_cargo_detached";

  static uint IGameEvent<EventDroneCargoDetached>.GetHash() => 0x958BD369u;
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
