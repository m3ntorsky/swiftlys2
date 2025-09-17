using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "achievement_info_loaded"
/// </summary>
public interface EventAchievementInfoLoaded : ITypedGameEvent<EventAchievementInfoLoaded> {

  static EventAchievementInfoLoaded ITypedGameEvent<EventAchievementInfoLoaded>.Wrap(IGameEvent accessor) => new EventAchievementInfoLoadedImpl(accessor);

  static string ITypedGameEvent<EventAchievementInfoLoaded>.GetName() => "achievement_info_loaded";

  static uint ITypedGameEvent<EventAchievementInfoLoaded>.GetHash() => 0x724EE32Fu;
}
