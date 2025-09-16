using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "bomb_exploded"
/// </summary>
public interface EventBombExploded : IGameEvent<EventBombExploded> {

  static EventBombExploded IGameEvent<EventBombExploded>.FromAllocated(nint ptr) => new EventBombExplodedImpl(ptr, true);

  static EventBombExploded IGameEvent<EventBombExploded>.FromExternal(nint ptr) => new EventBombExplodedImpl(ptr, false);

  static string IGameEvent<EventBombExploded>.GetName() => "bomb_exploded";

  static uint IGameEvent<EventBombExploded>.GetHash() => 0x9C543261u;
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
