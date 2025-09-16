using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "weapon_fire"
/// </summary>
public interface EventWeaponFire : IGameEvent<EventWeaponFire> {

  static EventWeaponFire IGameEvent<EventWeaponFire>.FromAllocated(nint ptr) => new EventWeaponFireImpl(ptr, true);

  static EventWeaponFire IGameEvent<EventWeaponFire>.FromExternal(nint ptr) => new EventWeaponFireImpl(ptr, false);

  static string IGameEvent<EventWeaponFire>.GetName() => "weapon_fire";

  static uint IGameEvent<EventWeaponFire>.GetHash() => 0x78A2D0FEu;
  /// <summary>
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// weapon name used
  /// <br/>
  /// type: string
  /// </summary>
  string Weapon { get; set; }

  /// <summary>
  /// is weapon silenced
  /// <br/>
  /// type: bool
  /// </summary>
  bool Silenced { get; set; }

}
