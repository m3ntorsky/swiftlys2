using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "vip_escaped"
/// </summary>
public interface EventVipEscaped : ITypedGameEvent<EventVipEscaped> {

  static EventVipEscaped ITypedGameEvent<EventVipEscaped>.Wrap(IGameEvent accessor) => new EventVipEscapedImpl(accessor);

  static string ITypedGameEvent<EventVipEscaped>.GetName() => "vip_escaped";

  static uint ITypedGameEvent<EventVipEscaped>.GetHash() => 0x30143B6Eu;
  /// <summary>
  /// player who was the VIP
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

}
