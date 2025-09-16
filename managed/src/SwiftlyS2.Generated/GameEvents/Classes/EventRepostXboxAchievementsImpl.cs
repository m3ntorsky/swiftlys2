using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "repost_xbox_achievements"
/// </summary>
internal class EventRepostXboxAchievementsImpl : GameEvent<EventRepostXboxAchievements>, EventRepostXboxAchievements
{

  public EventRepostXboxAchievementsImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // splitscreen ID
  public short SplitScreenPlayer
  { get => (short)GetInt("splitscreenplayer"); set => SetInt("splitscreenplayer", value); }
}
