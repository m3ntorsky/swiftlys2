using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "bot_takeover"
/// </summary>
public interface EventBotTakeover : ITypedGameEvent<EventBotTakeover> {

  static EventBotTakeover ITypedGameEvent<EventBotTakeover>.Wrap(IGameEvent accessor) => new EventBotTakeoverImpl(accessor);

  static string ITypedGameEvent<EventBotTakeover>.GetName() => "bot_takeover";

  static uint ITypedGameEvent<EventBotTakeover>.GetHash() => 0x6F5C9FCAu;
  /// <summary>
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// type: player_controller
  /// </summary>
  int BotID { get; set; }

  /// <summary>
  /// type: float
  /// </summary>
  float P { get; set; }

  /// <summary>
  /// type: float
  /// </summary>
  float Y { get; set; }

  /// <summary>
  /// type: float
  /// </summary>
  float R { get; set; }

}
