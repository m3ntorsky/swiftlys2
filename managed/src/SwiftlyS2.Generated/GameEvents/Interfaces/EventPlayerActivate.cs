using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "player_activate"
/// </summary>
public interface EventPlayerActivate : IGameEvent<EventPlayerActivate> {

  static EventPlayerActivate IGameEvent<EventPlayerActivate>.FromAllocated(nint ptr) => new EventPlayerActivateImpl(ptr, true);

  static EventPlayerActivate IGameEvent<EventPlayerActivate>.FromExternal(nint ptr) => new EventPlayerActivateImpl(ptr, false);

  static string IGameEvent<EventPlayerActivate>.GetName() => "player_activate";

  static uint IGameEvent<EventPlayerActivate>.GetHash() => 0x5C0DF448u;
  /// <summary>
  /// user ID on server
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

}
