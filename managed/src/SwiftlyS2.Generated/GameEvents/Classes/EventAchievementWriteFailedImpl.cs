using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "achievement_write_failed"
/// </summary>
internal class EventAchievementWriteFailedImpl : TypedGameEvent<EventAchievementWriteFailed>, EventAchievementWriteFailed
{

  public EventAchievementWriteFailedImpl(IGameEvent accessor) : base(accessor)
  {
  }
}
