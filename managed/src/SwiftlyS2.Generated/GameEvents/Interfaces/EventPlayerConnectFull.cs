using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "player_connect_full"
/// player has sent final message in the connection sequence
/// </summary>
public interface EventPlayerConnectFull : ITypedGameEvent<EventPlayerConnectFull> {

  static EventPlayerConnectFull ITypedGameEvent<EventPlayerConnectFull>.Wrap(IGameEvent accessor) => new EventPlayerConnectFullImpl(accessor);

  static string ITypedGameEvent<EventPlayerConnectFull>.GetName() => "player_connect_full";

  static uint ITypedGameEvent<EventPlayerConnectFull>.GetHash() => 0x5BE3B233u;
  /// <summary>
  /// user ID on server (unique on server)
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

}
