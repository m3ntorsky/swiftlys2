using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "gc_connected"
/// </summary>
public interface EventGcConnected : IGameEvent<EventGcConnected> {

  static EventGcConnected IGameEvent<EventGcConnected>.Create() => new EventGcConnectedImpl();

  static string IGameEvent<EventGcConnected>.GetName() => "gc_connected";

  static uint IGameEvent<EventGcConnected>.GetHash() => 0xAEFB8477u;
}
