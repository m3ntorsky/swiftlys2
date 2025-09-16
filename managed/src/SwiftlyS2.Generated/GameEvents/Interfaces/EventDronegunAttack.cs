using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "dronegun_attack"
/// </summary>
public interface EventDronegunAttack : IGameEvent<EventDronegunAttack> {

  static EventDronegunAttack IGameEvent<EventDronegunAttack>.FromAllocated(nint ptr) => new EventDronegunAttackImpl(ptr, true);

  static EventDronegunAttack IGameEvent<EventDronegunAttack>.FromExternal(nint ptr) => new EventDronegunAttackImpl(ptr, false);

  static string IGameEvent<EventDronegunAttack>.GetName() => "dronegun_attack";

  static uint IGameEvent<EventDronegunAttack>.GetHash() => 0x3EB09776u;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

}
