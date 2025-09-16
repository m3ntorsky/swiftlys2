using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "bot_takeover"
/// </summary>
public interface EventBotTakeover : IGameEvent<EventBotTakeover> {

  static EventBotTakeover IGameEvent<EventBotTakeover>.FromAllocated(nint ptr) => new EventBotTakeoverImpl(ptr, true);

  static EventBotTakeover IGameEvent<EventBotTakeover>.FromExternal(nint ptr) => new EventBotTakeoverImpl(ptr, false);

  static string IGameEvent<EventBotTakeover>.GetName() => "bot_takeover";

  static uint IGameEvent<EventBotTakeover>.GetHash() => 0x6F5C9FCAu;
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
