using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "door_moving"
/// </summary>
public interface EventDoorMoving : IGameEvent<EventDoorMoving> {

  static EventDoorMoving IGameEvent<EventDoorMoving>.FromAllocated(nint ptr) => new EventDoorMovingImpl(ptr, true);

  static EventDoorMoving IGameEvent<EventDoorMoving>.FromExternal(nint ptr) => new EventDoorMovingImpl(ptr, false);

  static string IGameEvent<EventDoorMoving>.GetName() => "door_moving";

  static uint IGameEvent<EventDoorMoving>.GetHash() => 0x253FA168u;
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
