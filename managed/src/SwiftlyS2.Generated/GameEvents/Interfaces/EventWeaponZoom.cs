using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "weapon_zoom"
/// </summary>
public interface EventWeaponZoom : ITypedGameEvent<EventWeaponZoom> {

  static EventWeaponZoom ITypedGameEvent<EventWeaponZoom>.Wrap(IGameEvent accessor) => new EventWeaponZoomImpl(accessor);

  static string ITypedGameEvent<EventWeaponZoom>.GetName() => "weapon_zoom";

  static uint ITypedGameEvent<EventWeaponZoom>.GetHash() => 0xBF1A06E1u;
  /// <summary>
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

}
