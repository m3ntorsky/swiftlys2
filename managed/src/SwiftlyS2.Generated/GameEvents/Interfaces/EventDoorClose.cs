using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "door_close"
/// </summary>
public interface EventDoorClose : ITypedGameEvent<EventDoorClose> {

  static EventDoorClose ITypedGameEvent<EventDoorClose>.Wrap(IGameEvent accessor) => new EventDoorCloseImpl(accessor);

  static string ITypedGameEvent<EventDoorClose>.GetName() => "door_close";

  static uint ITypedGameEvent<EventDoorClose>.GetHash() => 0xC96E7A7Eu;
  /// <summary>
  /// Who closed the door
  /// <br/>
  /// type: player_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// Is the door a checkpoint door
  /// <br/>
  /// type: bool
  /// </summary>
  bool Checkpoint { get; set; }

}
