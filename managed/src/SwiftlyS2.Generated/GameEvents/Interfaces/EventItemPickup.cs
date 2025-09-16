using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "item_pickup"
/// </summary>
public interface EventItemPickup : IGameEvent<EventItemPickup> {

  static EventItemPickup IGameEvent<EventItemPickup>.FromAllocated(nint ptr) => new EventItemPickupImpl(ptr, true);

  static EventItemPickup IGameEvent<EventItemPickup>.FromExternal(nint ptr) => new EventItemPickupImpl(ptr, false);

  static string IGameEvent<EventItemPickup>.GetName() => "item_pickup";

  static uint IGameEvent<EventItemPickup>.GetHash() => 0x58CEF8C3u;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// either a weapon such as 'tmp' or 'hegrenade', or an item such as 'nvgs'
  /// <br/>
  /// type: string
  /// </summary>
  string Item { get; set; }

  /// <summary>
  /// type: bool
  /// </summary>
  bool Silent { get; set; }

  /// <summary>
  /// type: long
  /// </summary>
  int DefIndex { get; set; }

}
