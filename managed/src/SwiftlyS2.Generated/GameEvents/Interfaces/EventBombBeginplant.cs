using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "bomb_beginplant"
/// </summary>
public interface EventBombBeginplant : IGameEvent<EventBombBeginplant> {

  static EventBombBeginplant IGameEvent<EventBombBeginplant>.FromAllocated(nint ptr) => new EventBombBeginplantImpl(ptr, true);

  static EventBombBeginplant IGameEvent<EventBombBeginplant>.FromExternal(nint ptr) => new EventBombBeginplantImpl(ptr, false);

  static string IGameEvent<EventBombBeginplant>.GetName() => "bomb_beginplant";

  static uint IGameEvent<EventBombBeginplant>.GetHash() => 0x7DD410C4u;
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
