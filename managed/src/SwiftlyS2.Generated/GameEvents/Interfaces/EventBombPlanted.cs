using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "bomb_planted"
/// </summary>
public interface EventBombPlanted : IGameEvent<EventBombPlanted> {

  static EventBombPlanted IGameEvent<EventBombPlanted>.FromAllocated(nint ptr) => new EventBombPlantedImpl(ptr, true);

  static EventBombPlanted IGameEvent<EventBombPlanted>.FromExternal(nint ptr) => new EventBombPlantedImpl(ptr, false);

  static string IGameEvent<EventBombPlanted>.GetName() => "bomb_planted";

  static uint IGameEvent<EventBombPlanted>.GetHash() => 0x4E704C3Eu;
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
