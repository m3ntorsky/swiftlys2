using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "exit_buyzone"
/// </summary>
public interface EventExitBuyzone : IGameEvent<EventExitBuyzone> {

  static EventExitBuyzone IGameEvent<EventExitBuyzone>.FromAllocated(nint ptr) => new EventExitBuyzoneImpl(ptr, true);

  static EventExitBuyzone IGameEvent<EventExitBuyzone>.FromExternal(nint ptr) => new EventExitBuyzoneImpl(ptr, false);

  static string IGameEvent<EventExitBuyzone>.GetName() => "exit_buyzone";

  static uint IGameEvent<EventExitBuyzone>.GetHash() => 0x9DF26040u;
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
