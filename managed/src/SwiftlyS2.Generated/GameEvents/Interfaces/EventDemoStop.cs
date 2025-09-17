using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "demo_stop"
/// </summary>
public interface EventDemoStop : ITypedGameEvent<EventDemoStop> {

  static EventDemoStop ITypedGameEvent<EventDemoStop>.Wrap(IGameEvent accessor) => new EventDemoStopImpl(accessor);

  static string ITypedGameEvent<EventDemoStop>.GetName() => "demo_stop";

  static uint ITypedGameEvent<EventDemoStop>.GetHash() => 0xDF8418C3u;
}
