using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "achievement_event"
/// </summary>
internal class EventAchievementEventImpl : GameEvent<EventAchievementEvent>, EventAchievementEvent
{

  public EventAchievementEventImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // non-localized name of achievement
  public string AchievementName
  { get => GetString("achievement_name"); set => SetString("achievement_name", value); }

  // # of steps toward achievement
  public short CurVal
  { get => (short)GetInt("cur_val"); set => SetInt("cur_val", value); }

  // total # of steps in achievement
  public short MaxVal
  { get => (short)GetInt("max_val"); set => SetInt("max_val", value); }
}
