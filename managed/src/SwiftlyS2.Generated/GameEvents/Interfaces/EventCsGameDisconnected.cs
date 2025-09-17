using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "cs_game_disconnected"
/// </summary>
public interface EventCsGameDisconnected : ITypedGameEvent<EventCsGameDisconnected> {

  static EventCsGameDisconnected ITypedGameEvent<EventCsGameDisconnected>.Wrap(IGameEvent accessor) => new EventCsGameDisconnectedImpl(accessor);

  static string ITypedGameEvent<EventCsGameDisconnected>.GetName() => "cs_game_disconnected";

  static uint ITypedGameEvent<EventCsGameDisconnected>.GetHash() => 0xC1557D00u;
}
