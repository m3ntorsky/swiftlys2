using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "achievement_earned"
/// </summary>
internal class EventAchievementEarnedImpl : GameEvent<EventAchievementEarned>, EventAchievementEarned
{

  public EventAchievementEarnedImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // entindex of the player
  public int Player
  { get => GetPlayerSlot("player"); set => SetPlayerSlot("player", value); }

  // achievement ID
  public short Achievement
  { get => (short)GetInt("achievement"); set => SetInt("achievement", value); }
}
