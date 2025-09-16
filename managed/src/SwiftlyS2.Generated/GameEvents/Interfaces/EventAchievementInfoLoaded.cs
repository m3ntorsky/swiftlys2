using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "achievement_info_loaded"
/// </summary>
public interface EventAchievementInfoLoaded : IGameEvent<EventAchievementInfoLoaded> {

  static EventAchievementInfoLoaded IGameEvent<EventAchievementInfoLoaded>.FromAllocated(nint ptr) => new EventAchievementInfoLoadedImpl(ptr, true);

  static EventAchievementInfoLoaded IGameEvent<EventAchievementInfoLoaded>.FromExternal(nint ptr) => new EventAchievementInfoLoadedImpl(ptr, false);

  static string IGameEvent<EventAchievementInfoLoaded>.GetName() => "achievement_info_loaded";

  static uint IGameEvent<EventAchievementInfoLoaded>.GetHash() => 0x724EE32Fu;
}
