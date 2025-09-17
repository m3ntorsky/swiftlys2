using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "weapon_fire_on_empty"
/// </summary>
public interface EventWeaponFireOnEmpty : ITypedGameEvent<EventWeaponFireOnEmpty> {

  static EventWeaponFireOnEmpty ITypedGameEvent<EventWeaponFireOnEmpty>.Wrap(IGameEvent accessor) => new EventWeaponFireOnEmptyImpl(accessor);

  static string ITypedGameEvent<EventWeaponFireOnEmpty>.GetName() => "weapon_fire_on_empty";

  static uint ITypedGameEvent<EventWeaponFireOnEmpty>.GetHash() => 0xB2954170u;
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

}
