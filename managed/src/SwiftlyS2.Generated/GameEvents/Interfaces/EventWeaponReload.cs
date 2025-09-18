using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "weapon_reload"
/// </summary>
public interface EventWeaponReload : IGameEvent<EventWeaponReload> {

  static EventWeaponReload IGameEvent<EventWeaponReload>.Create() => new EventWeaponReloadImpl();

  static string IGameEvent<EventWeaponReload>.GetName() => "weapon_reload";

  static uint IGameEvent<EventWeaponReload>.GetHash() => 0x387E603Fu;
  /// <summary>
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserIdController { get; }

  /// <summary>
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerPawn UserIdPawn { get; }

  /// <summary>
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  int UserId { get; set; }

}
