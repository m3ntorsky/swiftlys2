using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "player_connect"
/// a new client connected
/// </summary>
public interface EventPlayerConnect : ITypedGameEvent<EventPlayerConnect> {

  static EventPlayerConnect ITypedGameEvent<EventPlayerConnect>.Create() => new EventPlayerConnectImpl();

  static string ITypedGameEvent<EventPlayerConnect>.GetName() => "player_connect";

  static uint ITypedGameEvent<EventPlayerConnect>.GetHash() => 0x721B9701u;
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
  /// type: string
  /// </summary>
  string NetworkID { get; set; }

  /// <summary>
  /// steam id
  /// <br/>
  /// type: uint64
  /// </summary>
  ulong XuID { get; set; }

  /// <summary>
  /// type: bool
  /// </summary>
  bool Bot { get; set; }

}
