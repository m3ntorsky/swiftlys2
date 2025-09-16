using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "achievement_write_failed"
/// </summary>
public interface EventAchievementWriteFailed : IGameEvent<EventAchievementWriteFailed> {

  static EventAchievementWriteFailed IGameEvent<EventAchievementWriteFailed>.FromAllocated(nint ptr) => new EventAchievementWriteFailedImpl(ptr, true);

  static EventAchievementWriteFailed IGameEvent<EventAchievementWriteFailed>.FromExternal(nint ptr) => new EventAchievementWriteFailedImpl(ptr, false);

  static string IGameEvent<EventAchievementWriteFailed>.GetName() => "achievement_write_failed";

  static uint IGameEvent<EventAchievementWriteFailed>.GetHash() => 0x271251F8u;
}
