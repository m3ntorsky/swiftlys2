using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "enter_buyzone"
/// </summary>
public interface EventEnterBuyzone : ITypedGameEvent<EventEnterBuyzone> {

  static EventEnterBuyzone ITypedGameEvent<EventEnterBuyzone>.Create() => new EventEnterBuyzoneImpl();

  static string ITypedGameEvent<EventEnterBuyzone>.GetName() => "enter_buyzone";

  static uint ITypedGameEvent<EventEnterBuyzone>.GetHash() => 0x9E49E798u;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// type: bool
  /// </summary>
  bool CanBuy { get; set; }

}
