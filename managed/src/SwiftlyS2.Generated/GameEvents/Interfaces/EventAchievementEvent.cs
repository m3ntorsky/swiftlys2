using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "achievement_event"
/// </summary>
public interface EventAchievementEvent : ITypedGameEvent<EventAchievementEvent> {

  static EventAchievementEvent ITypedGameEvent<EventAchievementEvent>.Wrap(IGameEvent accessor) => new EventAchievementEventImpl(accessor);

  static string ITypedGameEvent<EventAchievementEvent>.GetName() => "achievement_event";

  static uint ITypedGameEvent<EventAchievementEvent>.GetHash() => 0x00F01BDFu;
  /// <summary>
  /// non-localized name of achievement
  /// <br/>
  /// type: string
  /// </summary>
  string AchievementName { get; set; }

  /// <summary>
  /// # of steps toward achievement
  /// <br/>
  /// type: short
  /// </summary>
  short CurVal { get; set; }

  /// <summary>
  /// total # of steps in achievement
  /// <br/>
  /// type: short
  /// </summary>
  short MaxVal { get; set; }

}
