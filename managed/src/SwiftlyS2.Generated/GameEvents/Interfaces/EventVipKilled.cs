using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "vip_killed"
/// </summary>
public interface EventVipKilled : IGameEvent<EventVipKilled> {

  static EventVipKilled IGameEvent<EventVipKilled>.FromAllocated(nint ptr) => new EventVipKilledImpl(ptr, true);

  static EventVipKilled IGameEvent<EventVipKilled>.FromExternal(nint ptr) => new EventVipKilledImpl(ptr, false);

  static string IGameEvent<EventVipKilled>.GetName() => "vip_killed";

  static uint IGameEvent<EventVipKilled>.GetHash() => 0x21FB59C8u;
  /// <summary>
  /// player who was the VIP
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// user ID who killed the VIP
  /// <br/>
  /// type: player_controller
  /// </summary>
  int Attacker { get; set; }

}
