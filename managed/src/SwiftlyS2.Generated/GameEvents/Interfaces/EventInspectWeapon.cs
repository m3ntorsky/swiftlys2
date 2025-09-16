using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "inspect_weapon"
/// </summary>
public interface EventInspectWeapon : IGameEvent<EventInspectWeapon> {

  static EventInspectWeapon IGameEvent<EventInspectWeapon>.FromAllocated(nint ptr) => new EventInspectWeaponImpl(ptr, true);

  static EventInspectWeapon IGameEvent<EventInspectWeapon>.FromExternal(nint ptr) => new EventInspectWeaponImpl(ptr, false);

  static string IGameEvent<EventInspectWeapon>.GetName() => "inspect_weapon";

  static uint IGameEvent<EventInspectWeapon>.GetHash() => 0x211A0C2Cu;
  /// <summary>
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

}
