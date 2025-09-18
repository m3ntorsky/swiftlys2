using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "bomb_dropped"
/// </summary>
public interface EventBombDropped : IGameEvent<EventBombDropped> {

  static EventBombDropped IGameEvent<EventBombDropped>.Create() => new EventBombDroppedImpl();

  static string IGameEvent<EventBombDropped>.GetName() => "bomb_dropped";

  static uint IGameEvent<EventBombDropped>.GetHash() => 0x399275B4u;
  /// <summary>
  /// player who dropped the bomb
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserIdController { get; }

  /// <summary>
  /// player who dropped the bomb
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerPawn UserIdPawn { get; }

  /// <summary>
  /// player who dropped the bomb
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  int UserId { get; set; }

  /// <summary>
  /// type: long
  /// </summary>
  int EntIndex { get; set; }

}
