using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "bomb_defused"
/// </summary>
public interface EventBombDefused : IGameEvent<EventBombDefused> {

  static EventBombDefused IGameEvent<EventBombDefused>.FromAllocated(nint ptr) => new EventBombDefusedImpl(ptr, true);

  static EventBombDefused IGameEvent<EventBombDefused>.FromExternal(nint ptr) => new EventBombDefusedImpl(ptr, false);

  static string IGameEvent<EventBombDefused>.GetName() => "bomb_defused";

  static uint IGameEvent<EventBombDefused>.GetHash() => 0xD4FCB0A4u;
  /// <summary>
  /// player who defused the bomb
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
