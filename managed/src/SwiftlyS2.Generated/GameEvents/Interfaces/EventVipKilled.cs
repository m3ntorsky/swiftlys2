using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "vip_killed"
/// </summary>
public interface EventVipKilled : ITypedGameEvent<EventVipKilled> {

  static EventVipKilled ITypedGameEvent<EventVipKilled>.Wrap(IGameEvent accessor) => new EventVipKilledImpl(accessor);

  static string ITypedGameEvent<EventVipKilled>.GetName() => "vip_killed";

  static uint ITypedGameEvent<EventVipKilled>.GetHash() => 0x21FB59C8u;
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
