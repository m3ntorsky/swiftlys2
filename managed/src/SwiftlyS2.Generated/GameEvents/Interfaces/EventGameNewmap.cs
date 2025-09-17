using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "game_newmap"
/// send when new map is completely loaded
/// </summary>
public interface EventGameNewmap : ITypedGameEvent<EventGameNewmap> {

  static EventGameNewmap ITypedGameEvent<EventGameNewmap>.Wrap(IGameEvent accessor) => new EventGameNewmapImpl(accessor);

  static string ITypedGameEvent<EventGameNewmap>.GetName() => "game_newmap";

  static uint ITypedGameEvent<EventGameNewmap>.GetHash() => 0xF0D60440u;
  /// <summary>
  /// map name
  /// <br/>
  /// type: string
  /// </summary>
  string MapName { get; set; }

  /// <summary>
  /// true if this is a transition from one map to another
  /// <br/>
  /// type: bool
  /// </summary>
  bool Transition { get; set; }

}
