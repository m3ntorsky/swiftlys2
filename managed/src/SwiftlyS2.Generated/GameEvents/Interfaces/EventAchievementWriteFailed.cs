using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "achievement_write_failed"
/// </summary>
public interface EventAchievementWriteFailed : ITypedGameEvent<EventAchievementWriteFailed> {

  static EventAchievementWriteFailed ITypedGameEvent<EventAchievementWriteFailed>.Wrap(IGameEvent accessor) => new EventAchievementWriteFailedImpl(accessor);

  static string ITypedGameEvent<EventAchievementWriteFailed>.GetName() => "achievement_write_failed";

  static uint ITypedGameEvent<EventAchievementWriteFailed>.GetHash() => 0x271251F8u;
}
