using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "vip_killed"
/// </summary>
internal class EventVipKilledImpl : GameEvent<EventVipKilled>, EventVipKilled
{

  public EventVipKilledImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // player who was the VIP
  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  // user ID who killed the VIP
  public int Attacker
  { get => GetPlayerSlot("attacker"); set => SetPlayerSlot("attacker", value); }
}
