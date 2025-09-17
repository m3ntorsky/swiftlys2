using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "weapon_reload"
/// </summary>
public interface EventWeaponReload : ITypedGameEvent<EventWeaponReload> {

  static EventWeaponReload ITypedGameEvent<EventWeaponReload>.Create() => new EventWeaponReloadImpl();

  static string ITypedGameEvent<EventWeaponReload>.GetName() => "weapon_reload";

  static uint ITypedGameEvent<EventWeaponReload>.GetHash() => 0x387E603Fu;
  /// <summary>
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

}
