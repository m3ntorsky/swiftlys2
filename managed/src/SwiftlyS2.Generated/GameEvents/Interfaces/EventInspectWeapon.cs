using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "inspect_weapon"
/// </summary>
public interface EventInspectWeapon : ITypedGameEvent<EventInspectWeapon> {

  static EventInspectWeapon ITypedGameEvent<EventInspectWeapon>.Create() => new EventInspectWeaponImpl();

  static string ITypedGameEvent<EventInspectWeapon>.GetName() => "inspect_weapon";

  static uint ITypedGameEvent<EventInspectWeapon>.GetHash() => 0x211A0C2Cu;
  /// <summary>
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

}
