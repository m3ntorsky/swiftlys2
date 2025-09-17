using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "ammo_pickup"
/// </summary>
public interface EventAmmoPickup : ITypedGameEvent<EventAmmoPickup> {

  static EventAmmoPickup ITypedGameEvent<EventAmmoPickup>.Create() => new EventAmmoPickupImpl();

  static string ITypedGameEvent<EventAmmoPickup>.GetName() => "ammo_pickup";

  static uint ITypedGameEvent<EventAmmoPickup>.GetHash() => 0x374B5BCCu;
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
