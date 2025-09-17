using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "bomb_exploded"
/// </summary>
public interface EventBombExploded : ITypedGameEvent<EventBombExploded> {

  static EventBombExploded ITypedGameEvent<EventBombExploded>.Wrap(IGameEvent accessor) => new EventBombExplodedImpl(accessor);

  static string ITypedGameEvent<EventBombExploded>.GetName() => "bomb_exploded";

  static uint ITypedGameEvent<EventBombExploded>.GetHash() => 0x9C543261u;
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
