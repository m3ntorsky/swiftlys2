using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "player_chat"
/// a public player chat
/// </summary>
public interface EventPlayerChat : ITypedGameEvent<EventPlayerChat> {

  static EventPlayerChat ITypedGameEvent<EventPlayerChat>.Create() => new EventPlayerChatImpl();

  static string ITypedGameEvent<EventPlayerChat>.GetName() => "player_chat";

  static uint ITypedGameEvent<EventPlayerChat>.GetHash() => 0xA2C21BE3u;
  /// <summary>
  /// true if team only chat
  /// <br/>
  /// type: bool
  /// </summary>
  bool TeamOnly { get; set; }

  /// <summary>
  /// chatting player
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// chatting player ID
  /// <br/>
  /// type: short
  /// </summary>
  short Playerid { get; set; }

  /// <summary>
  /// chat text
  /// <br/>
  /// type: string
  /// </summary>
  string Text { get; set; }

}
