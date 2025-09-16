using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "weapon_zoom_rifle"
/// </summary>
public interface EventWeaponZoomRifle : IGameEvent<EventWeaponZoomRifle> {

  static EventWeaponZoomRifle IGameEvent<EventWeaponZoomRifle>.FromAllocated(nint ptr) => new EventWeaponZoomRifleImpl(ptr, true);

  static EventWeaponZoomRifle IGameEvent<EventWeaponZoomRifle>.FromExternal(nint ptr) => new EventWeaponZoomRifleImpl(ptr, false);

  static string IGameEvent<EventWeaponZoomRifle>.GetName() => "weapon_zoom_rifle";

  static uint IGameEvent<EventWeaponZoomRifle>.GetHash() => 0x4B7652E4u;
  /// <summary>
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

}
