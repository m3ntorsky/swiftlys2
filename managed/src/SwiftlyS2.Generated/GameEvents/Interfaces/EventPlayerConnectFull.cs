using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "player_connect_full"
/// player has sent final message in the connection sequence
/// </summary>
public interface EventPlayerConnectFull : IGameEvent<EventPlayerConnectFull> {

  static EventPlayerConnectFull IGameEvent<EventPlayerConnectFull>.FromAllocated(nint ptr) => new EventPlayerConnectFullImpl(ptr, true);

  static EventPlayerConnectFull IGameEvent<EventPlayerConnectFull>.FromExternal(nint ptr) => new EventPlayerConnectFullImpl(ptr, false);

  static string IGameEvent<EventPlayerConnectFull>.GetName() => "player_connect_full";

  static uint IGameEvent<EventPlayerConnectFull>.GetHash() => 0x5BE3B233u;
  /// <summary>
  /// user ID on server (unique on server)
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

}
