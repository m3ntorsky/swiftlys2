using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "dronegun_attack"
/// </summary>
public interface EventDronegunAttack : ITypedGameEvent<EventDronegunAttack> {

  static EventDronegunAttack ITypedGameEvent<EventDronegunAttack>.Wrap(IGameEvent accessor) => new EventDronegunAttackImpl(accessor);

  static string ITypedGameEvent<EventDronegunAttack>.GetName() => "dronegun_attack";

  static uint ITypedGameEvent<EventDronegunAttack>.GetHash() => 0x3EB09776u;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

}
