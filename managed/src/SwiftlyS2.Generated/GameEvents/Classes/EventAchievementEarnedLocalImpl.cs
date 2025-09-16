using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "achievement_earned_local"
/// </summary>
internal class EventAchievementEarnedLocalImpl : GameEvent<EventAchievementEarnedLocal>, EventAchievementEarnedLocal
{

  public EventAchievementEarnedLocalImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // achievement ID
  public short Achievement
  { get => (short)GetInt("achievement"); set => SetInt("achievement", value); }

  // splitscreen ID
  public short SplitScreenPlayer
  { get => (short)GetInt("splitscreenplayer"); set => SetInt("splitscreenplayer", value); }
}
