using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "dronegun_attack"
/// </summary>
public interface EventDronegunAttack : IGameEvent<EventDronegunAttack> {

  static EventDronegunAttack IGameEvent<EventDronegunAttack>.Create() => new EventDronegunAttackImpl();

  static string IGameEvent<EventDronegunAttack>.GetName() => "dronegun_attack";

  static uint IGameEvent<EventDronegunAttack>.GetHash() => 0x3EB09776u;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserIdController { get; }

  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerPawn UserIdPawn { get; }

  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  int UserId { get; set; }

}
