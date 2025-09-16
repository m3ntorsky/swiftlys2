using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "achievement_earned_local"
/// </summary>
public interface EventAchievementEarnedLocal : IGameEvent<EventAchievementEarnedLocal> {

  static EventAchievementEarnedLocal IGameEvent<EventAchievementEarnedLocal>.FromAllocated(nint ptr) => new EventAchievementEarnedLocalImpl(ptr, true);

  static EventAchievementEarnedLocal IGameEvent<EventAchievementEarnedLocal>.FromExternal(nint ptr) => new EventAchievementEarnedLocalImpl(ptr, false);

  static string IGameEvent<EventAchievementEarnedLocal>.GetName() => "achievement_earned_local";

  static uint IGameEvent<EventAchievementEarnedLocal>.GetHash() => 0x106FCE0Au;
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
