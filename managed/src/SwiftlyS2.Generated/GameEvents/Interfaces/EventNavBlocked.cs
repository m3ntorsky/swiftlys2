using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "nav_blocked"
/// </summary>
public interface EventNavBlocked : ITypedGameEvent<EventNavBlocked> {

  static EventNavBlocked ITypedGameEvent<EventNavBlocked>.Wrap(IGameEvent accessor) => new EventNavBlockedImpl(accessor);

  static string ITypedGameEvent<EventNavBlocked>.GetName() => "nav_blocked";

  static uint ITypedGameEvent<EventNavBlocked>.GetHash() => 0x1DE3B769u;
  /// <summary>
  /// type: long
  /// </summary>
  int Area { get; set; }

  /// <summary>
  /// type: bool
  /// </summary>
  bool Blocked { get; set; }

}
