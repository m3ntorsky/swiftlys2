using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "bomb_planted"
/// </summary>
public interface EventBombPlanted : ITypedGameEvent<EventBombPlanted> {

  static EventBombPlanted ITypedGameEvent<EventBombPlanted>.Create() => new EventBombPlantedImpl();

  static string ITypedGameEvent<EventBombPlanted>.GetName() => "bomb_planted";

  static uint ITypedGameEvent<EventBombPlanted>.GetHash() => 0x4E704C3Eu;
  /// <summary>
  /// player who planted the bomb
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// bombsite index
  /// <br/>
  /// type: short
  /// </summary>
  short Site { get; set; }

}
