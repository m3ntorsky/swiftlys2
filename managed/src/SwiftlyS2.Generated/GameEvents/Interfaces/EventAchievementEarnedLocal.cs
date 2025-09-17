using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "achievement_earned_local"
/// </summary>
public interface EventAchievementEarnedLocal : ITypedGameEvent<EventAchievementEarnedLocal> {

  static EventAchievementEarnedLocal ITypedGameEvent<EventAchievementEarnedLocal>.Create() => new EventAchievementEarnedLocalImpl();

  static string ITypedGameEvent<EventAchievementEarnedLocal>.GetName() => "achievement_earned_local";

  static uint ITypedGameEvent<EventAchievementEarnedLocal>.GetHash() => 0x106FCE0Au;
  /// <summary>
  /// achievement ID
  /// <br/>
  /// type: short
  /// </summary>
  short Achievement { get; set; }

  /// <summary>
  /// splitscreen ID
  /// <br/>
  /// type: short
  /// </summary>
  short SplitScreenPlayer { get; set; }

}
