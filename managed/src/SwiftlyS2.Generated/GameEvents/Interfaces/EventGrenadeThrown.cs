using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "grenade_thrown"
/// </summary>
public interface EventGrenadeThrown : IGameEvent<EventGrenadeThrown> {

  static EventGrenadeThrown IGameEvent<EventGrenadeThrown>.Create() => new EventGrenadeThrownImpl();

  static string IGameEvent<EventGrenadeThrown>.GetName() => "grenade_thrown";

  static uint IGameEvent<EventGrenadeThrown>.GetHash() => 0x0F018978u;
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

  /// <summary>
  /// weapon name used
  /// <br/>
  /// type: string
  /// </summary>
  string Weapon { get; set; }

}
