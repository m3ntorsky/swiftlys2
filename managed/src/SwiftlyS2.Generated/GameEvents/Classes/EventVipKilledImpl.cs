using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "vip_killed"
/// </summary>
internal class EventVipKilledImpl : TypedGameEvent<EventVipKilled>, EventVipKilled
{

  public EventVipKilledImpl(IGameEvent accessor) : base(accessor)
  {
  }

  // player who was the VIP
  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }

  // user ID who killed the VIP
  public int Attacker
  { get => Accessor.GetPlayerSlot("attacker"); set => Accessor.SetPlayerSlot("attacker", value); }
}
