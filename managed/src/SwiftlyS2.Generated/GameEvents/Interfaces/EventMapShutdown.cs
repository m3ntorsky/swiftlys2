using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "map_shutdown"
/// </summary>
public interface EventMapShutdown : ITypedGameEvent<EventMapShutdown> {

  static EventMapShutdown ITypedGameEvent<EventMapShutdown>.Create() => new EventMapShutdownImpl();

  static string ITypedGameEvent<EventMapShutdown>.GetName() => "map_shutdown";

  static uint ITypedGameEvent<EventMapShutdown>.GetHash() => 0xCA1507ECu;
}
