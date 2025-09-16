using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "enter_buyzone"
/// </summary>
public interface EventEnterBuyzone : IGameEvent<EventEnterBuyzone> {

  static EventEnterBuyzone IGameEvent<EventEnterBuyzone>.FromAllocated(nint ptr) => new EventEnterBuyzoneImpl(ptr, true);

  static EventEnterBuyzone IGameEvent<EventEnterBuyzone>.FromExternal(nint ptr) => new EventEnterBuyzoneImpl(ptr, false);

  static string IGameEvent<EventEnterBuyzone>.GetName() => "enter_buyzone";

  static uint IGameEvent<EventEnterBuyzone>.GetHash() => 0x9E49E798u;
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
