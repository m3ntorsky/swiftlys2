using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "ammo_refill"
/// </summary>
public interface EventAmmoRefill : ITypedGameEvent<EventAmmoRefill> {

  static EventAmmoRefill ITypedGameEvent<EventAmmoRefill>.Wrap(IGameEvent accessor) => new EventAmmoRefillImpl(accessor);

  static string ITypedGameEvent<EventAmmoRefill>.GetName() => "ammo_refill";

  static uint ITypedGameEvent<EventAmmoRefill>.GetHash() => 0x65179124u;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// type: bool
  /// </summary>
  bool Success { get; set; }

}
