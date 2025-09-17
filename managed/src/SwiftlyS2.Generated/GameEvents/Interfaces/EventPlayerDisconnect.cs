using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "player_disconnect"
/// a client was disconnected
/// </summary>
public interface EventPlayerDisconnect : ITypedGameEvent<EventPlayerDisconnect> {

  static EventPlayerDisconnect ITypedGameEvent<EventPlayerDisconnect>.Wrap(IGameEvent accessor) => new EventPlayerDisconnectImpl(accessor);

  static string ITypedGameEvent<EventPlayerDisconnect>.GetName() => "player_disconnect";

  static uint ITypedGameEvent<EventPlayerDisconnect>.GetHash() => 0x4FE1E633u;
  /// <summary>
  /// user ID on server
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// see networkdisconnect enum protobuf
  /// <br/>
  /// type: short
  /// </summary>
  short Reason { get; set; }

  /// <summary>
  /// player name
  /// <br/>
  /// type: string
  /// </summary>
  string Name { get; set; }

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
  /// type: short
  /// </summary>
  short PlayerID { get; set; }

}
