using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "repost_xbox_achievements"
/// </summary>
public interface EventRepostXboxAchievements : ITypedGameEvent<EventRepostXboxAchievements> {

  static EventRepostXboxAchievements ITypedGameEvent<EventRepostXboxAchievements>.Wrap(IGameEvent accessor) => new EventRepostXboxAchievementsImpl(accessor);

  static string ITypedGameEvent<EventRepostXboxAchievements>.GetName() => "repost_xbox_achievements";

  static uint ITypedGameEvent<EventRepostXboxAchievements>.GetHash() => 0x7D188D23u;
  /// <summary>
  /// splitscreen ID
  /// <br/>
  /// type: short
  /// </summary>
  short SplitScreenPlayer { get; set; }

}
