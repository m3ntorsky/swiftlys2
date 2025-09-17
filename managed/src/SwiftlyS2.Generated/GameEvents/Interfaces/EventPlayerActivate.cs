using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "player_activate"
/// </summary>
public interface EventPlayerActivate : ITypedGameEvent<EventPlayerActivate> {

  static EventPlayerActivate ITypedGameEvent<EventPlayerActivate>.Wrap(IGameEvent accessor) => new EventPlayerActivateImpl(accessor);

  static string ITypedGameEvent<EventPlayerActivate>.GetName() => "player_activate";

  static uint ITypedGameEvent<EventPlayerActivate>.GetHash() => 0x5C0DF448u;
  /// <summary>
  /// user ID on server
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

}
