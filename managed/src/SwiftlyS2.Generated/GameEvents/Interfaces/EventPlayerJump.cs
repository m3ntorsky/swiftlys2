using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "player_jump"
/// </summary>
public interface EventPlayerJump : ITypedGameEvent<EventPlayerJump> {

  static EventPlayerJump ITypedGameEvent<EventPlayerJump>.Wrap(IGameEvent accessor) => new EventPlayerJumpImpl(accessor);

  static string ITypedGameEvent<EventPlayerJump>.GetName() => "player_jump";

  static uint ITypedGameEvent<EventPlayerJump>.GetHash() => 0xA8C90F75u;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

}
