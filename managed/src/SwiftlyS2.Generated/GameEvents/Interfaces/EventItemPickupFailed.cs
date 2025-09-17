using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "item_pickup_failed"
/// </summary>
public interface EventItemPickupFailed : ITypedGameEvent<EventItemPickupFailed> {

  static EventItemPickupFailed ITypedGameEvent<EventItemPickupFailed>.Create() => new EventItemPickupFailedImpl();

  static string ITypedGameEvent<EventItemPickupFailed>.GetName() => "item_pickup_failed";

  static uint ITypedGameEvent<EventItemPickupFailed>.GetHash() => 0x0F6D19A9u;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// type: string
  /// </summary>
  string Item { get; set; }

  /// <summary>
  /// type: short
  /// </summary>
  short Reason { get; set; }

  /// <summary>
  /// type: short
  /// </summary>
  short Limit { get; set; }

}
