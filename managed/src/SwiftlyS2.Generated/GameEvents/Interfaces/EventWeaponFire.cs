using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "weapon_fire"
/// </summary>
public interface EventWeaponFire : ITypedGameEvent<EventWeaponFire> {

  static EventWeaponFire ITypedGameEvent<EventWeaponFire>.Create() => new EventWeaponFireImpl();

  static string ITypedGameEvent<EventWeaponFire>.GetName() => "weapon_fire";

  static uint ITypedGameEvent<EventWeaponFire>.GetHash() => 0x78A2D0FEu;
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
