using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "ammo_refill"
/// </summary>
public interface EventAmmoRefill : IGameEvent<EventAmmoRefill> {

  static EventAmmoRefill IGameEvent<EventAmmoRefill>.FromAllocated(nint ptr) => new EventAmmoRefillImpl(ptr, true);

  static EventAmmoRefill IGameEvent<EventAmmoRefill>.FromExternal(nint ptr) => new EventAmmoRefillImpl(ptr, false);

  static string IGameEvent<EventAmmoRefill>.GetName() => "ammo_refill";

  static uint IGameEvent<EventAmmoRefill>.GetHash() => 0x65179124u;
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
