using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "achievement_info_loaded"
/// </summary>
internal class EventAchievementInfoLoadedImpl : TypedGameEvent<EventAchievementInfoLoaded>, EventAchievementInfoLoaded
{

  public EventAchievementInfoLoadedImpl(IGameEvent accessor) : base(accessor)
  {
  }
}
