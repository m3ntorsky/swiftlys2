using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "vip_escaped"
/// </summary>
public interface EventVipEscaped : IGameEvent<EventVipEscaped> {

  static EventVipEscaped IGameEvent<EventVipEscaped>.Create() => new EventVipEscapedImpl();

  static string IGameEvent<EventVipEscaped>.GetName() => "vip_escaped";

  static uint IGameEvent<EventVipEscaped>.GetHash() => 0x30143B6Eu;
  /// <summary>
  /// player who was the VIP
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserIdController { get; }

  /// <summary>
  /// player who was the VIP
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerPawn UserIdPawn { get; }

  /// <summary>
  /// player who was the VIP
  /// <br/>
  /// type: player_controller
  /// </summary>
  int UserId { get; set; }

}
