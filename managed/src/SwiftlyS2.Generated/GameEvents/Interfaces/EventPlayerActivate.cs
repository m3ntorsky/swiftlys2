using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "player_activate"
/// </summary>
public interface EventPlayerActivate : IGameEvent<EventPlayerActivate> {

  static EventPlayerActivate IGameEvent<EventPlayerActivate>.Create() => new EventPlayerActivateImpl();

  static string IGameEvent<EventPlayerActivate>.GetName() => "player_activate";

  static uint IGameEvent<EventPlayerActivate>.GetHash() => 0x5C0DF448u;
  /// <summary>
  /// user ID on server
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserIdController { get; }

  /// <summary>
  /// user ID on server
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerPawn UserIdPawn { get; }

  /// <summary>
  /// user ID on server
  /// <br/>
  /// type: player_controller
  /// </summary>
  int UserId { get; set; }

}
