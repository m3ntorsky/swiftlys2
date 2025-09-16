using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "player_jump"
/// </summary>
public interface EventPlayerJump : IGameEvent<EventPlayerJump> {

  static EventPlayerJump IGameEvent<EventPlayerJump>.FromAllocated(nint ptr) => new EventPlayerJumpImpl(ptr, true);

  static EventPlayerJump IGameEvent<EventPlayerJump>.FromExternal(nint ptr) => new EventPlayerJumpImpl(ptr, false);

  static string IGameEvent<EventPlayerJump>.GetName() => "player_jump";

  static uint IGameEvent<EventPlayerJump>.GetHash() => 0xA8C90F75u;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

}
