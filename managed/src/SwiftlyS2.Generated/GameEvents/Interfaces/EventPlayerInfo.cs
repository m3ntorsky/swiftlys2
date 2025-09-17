using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "player_info"
/// a player changed his name
/// </summary>
public interface EventPlayerInfo : ITypedGameEvent<EventPlayerInfo> {

  static EventPlayerInfo ITypedGameEvent<EventPlayerInfo>.Create() => new EventPlayerInfoImpl();

  static string ITypedGameEvent<EventPlayerInfo>.GetName() => "player_info";

  static uint ITypedGameEvent<EventPlayerInfo>.GetHash() => 0x0A0BAFFDu;
  /// <summary>
  /// player name
  /// <br/>
  /// type: string
  /// </summary>
  string Name { get; set; }

  /// <summary>
  /// user ID on server (unique on server)
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// player network (i.e steam) id
  /// <br/>
  /// type: uint64
  /// </summary>
  ulong SteamID { get; set; }

  /// <summary>
  /// true if player is a AI bot
  /// <br/>
  /// type: bool
  /// </summary>
  bool Bot { get; set; }

}
