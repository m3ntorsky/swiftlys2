using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "gc_connected"
/// </summary>
public interface EventGcConnected : ITypedGameEvent<EventGcConnected> {

  static EventGcConnected ITypedGameEvent<EventGcConnected>.Wrap(IGameEvent accessor) => new EventGcConnectedImpl(accessor);

  static string ITypedGameEvent<EventGcConnected>.GetName() => "gc_connected";

  static uint ITypedGameEvent<EventGcConnected>.GetHash() => 0xAEFB8477u;
}
