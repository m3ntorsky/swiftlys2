using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "exit_buyzone"
/// </summary>
public interface EventExitBuyzone : ITypedGameEvent<EventExitBuyzone> {

  static EventExitBuyzone ITypedGameEvent<EventExitBuyzone>.Wrap(IGameEvent accessor) => new EventExitBuyzoneImpl(accessor);

  static string ITypedGameEvent<EventExitBuyzone>.GetName() => "exit_buyzone";

  static uint ITypedGameEvent<EventExitBuyzone>.GetHash() => 0x9DF26040u;
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
