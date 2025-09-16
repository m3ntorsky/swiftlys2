using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "ammo_pickup"
/// </summary>
public interface EventAmmoPickup : IGameEvent<EventAmmoPickup> {

  static EventAmmoPickup IGameEvent<EventAmmoPickup>.FromAllocated(nint ptr) => new EventAmmoPickupImpl(ptr, true);

  static EventAmmoPickup IGameEvent<EventAmmoPickup>.FromExternal(nint ptr) => new EventAmmoPickupImpl(ptr, false);

  static string IGameEvent<EventAmmoPickup>.GetName() => "ammo_pickup";

  static uint IGameEvent<EventAmmoPickup>.GetHash() => 0x374B5BCCu;
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
  /// the weapon entindex
  /// <br/>
  /// type: long
  /// </summary>
  int Index { get; set; }

}
