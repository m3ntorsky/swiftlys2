using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "player_changename"
/// </summary>
public interface EventPlayerChangename : IGameEvent<EventPlayerChangename> {

  static EventPlayerChangename IGameEvent<EventPlayerChangename>.FromAllocated(nint ptr) => new EventPlayerChangenameImpl(ptr, true);

  static EventPlayerChangename IGameEvent<EventPlayerChangename>.FromExternal(nint ptr) => new EventPlayerChangenameImpl(ptr, false);

  static string IGameEvent<EventPlayerChangename>.GetName() => "player_changename";

  static uint IGameEvent<EventPlayerChangename>.GetHash() => 0xD955F966u;
  /// <summary>
  /// user ID on server
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// players old (current) name
  /// <br/>
  /// type: string
  /// </summary>
  string OldName { get; set; }

  /// <summary>
  /// players new name
  /// <br/>
  /// type: string
  /// </summary>
  string NewName { get; set; }

}
