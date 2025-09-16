using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "bomb_abortplant"
/// </summary>
public interface EventBombAbortplant : IGameEvent<EventBombAbortplant> {

  static EventBombAbortplant IGameEvent<EventBombAbortplant>.FromAllocated(nint ptr) => new EventBombAbortplantImpl(ptr, true);

  static EventBombAbortplant IGameEvent<EventBombAbortplant>.FromExternal(nint ptr) => new EventBombAbortplantImpl(ptr, false);

  static string IGameEvent<EventBombAbortplant>.GetName() => "bomb_abortplant";

  static uint IGameEvent<EventBombAbortplant>.GetHash() => 0x7F1DB601u;
  /// <summary>
  /// player who is planting the bomb
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
