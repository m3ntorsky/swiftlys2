using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "grenade_thrown"
/// </summary>
public interface EventGrenadeThrown : ITypedGameEvent<EventGrenadeThrown> {

  static EventGrenadeThrown ITypedGameEvent<EventGrenadeThrown>.Create() => new EventGrenadeThrownImpl();

  static string ITypedGameEvent<EventGrenadeThrown>.GetName() => "grenade_thrown";

  static uint ITypedGameEvent<EventGrenadeThrown>.GetHash() => 0x0F018978u;
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
