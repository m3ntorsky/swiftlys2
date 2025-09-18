using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "client_disconnect"
/// </summary>
public interface EventClientDisconnect : IGameEvent<EventClientDisconnect> {

  static EventClientDisconnect IGameEvent<EventClientDisconnect>.Create() => new EventClientDisconnectImpl();

  static string IGameEvent<EventClientDisconnect>.GetName() => "client_disconnect";

  static uint IGameEvent<EventClientDisconnect>.GetHash() => 0xC714BB79u;
}
