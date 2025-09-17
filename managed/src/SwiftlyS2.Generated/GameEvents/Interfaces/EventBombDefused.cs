using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "bomb_defused"
/// </summary>
public interface EventBombDefused : ITypedGameEvent<EventBombDefused> {

  static EventBombDefused ITypedGameEvent<EventBombDefused>.Wrap(IGameEvent accessor) => new EventBombDefusedImpl(accessor);

  static string ITypedGameEvent<EventBombDefused>.GetName() => "bomb_defused";

  static uint ITypedGameEvent<EventBombDefused>.GetHash() => 0xD4FCB0A4u;
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
