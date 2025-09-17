using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "grenade_bounce"
/// </summary>
public interface EventGrenadeBounce : ITypedGameEvent<EventGrenadeBounce> {

  static EventGrenadeBounce ITypedGameEvent<EventGrenadeBounce>.Wrap(IGameEvent accessor) => new EventGrenadeBounceImpl(accessor);

  static string ITypedGameEvent<EventGrenadeBounce>.GetName() => "grenade_bounce";

  static uint ITypedGameEvent<EventGrenadeBounce>.GetHash() => 0xF75C5166u;
  /// <summary>
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

}
