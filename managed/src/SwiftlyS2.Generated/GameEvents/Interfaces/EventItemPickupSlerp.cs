using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "item_pickup_slerp"
/// </summary>
public interface EventItemPickupSlerp : IGameEvent<EventItemPickupSlerp> {

  static EventItemPickupSlerp IGameEvent<EventItemPickupSlerp>.FromAllocated(nint ptr) => new EventItemPickupSlerpImpl(ptr, true);

  static EventItemPickupSlerp IGameEvent<EventItemPickupSlerp>.FromExternal(nint ptr) => new EventItemPickupSlerpImpl(ptr, false);

  static string IGameEvent<EventItemPickupSlerp>.GetName() => "item_pickup_slerp";

  static uint IGameEvent<EventItemPickupSlerp>.GetHash() => 0x88B06F48u;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// type: short
  /// </summary>
  short Index { get; set; }

  /// <summary>
  /// type: short
  /// </summary>
  short Behavior { get; set; }

}
