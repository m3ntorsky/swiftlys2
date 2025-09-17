using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "weapon_zoom_rifle"
/// </summary>
public interface EventWeaponZoomRifle : ITypedGameEvent<EventWeaponZoomRifle> {

  static EventWeaponZoomRifle ITypedGameEvent<EventWeaponZoomRifle>.Wrap(IGameEvent accessor) => new EventWeaponZoomRifleImpl(accessor);

  static string ITypedGameEvent<EventWeaponZoomRifle>.GetName() => "weapon_zoom_rifle";

  static uint ITypedGameEvent<EventWeaponZoomRifle>.GetHash() => 0x4B7652E4u;
  /// <summary>
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

}
