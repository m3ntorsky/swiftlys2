using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "door_moving"
/// </summary>
public interface EventDoorMoving : ITypedGameEvent<EventDoorMoving> {

  static EventDoorMoving ITypedGameEvent<EventDoorMoving>.Create() => new EventDoorMovingImpl();

  static string ITypedGameEvent<EventDoorMoving>.GetName() => "door_moving";

  static uint ITypedGameEvent<EventDoorMoving>.GetHash() => 0x253FA168u;
  /// <summary>
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// type: long
  /// </summary>
  int EntIndex { get; set; }

}
