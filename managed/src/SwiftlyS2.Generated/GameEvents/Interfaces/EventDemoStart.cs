using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "demo_start"
/// </summary>
public interface EventDemoStart : ITypedGameEvent<EventDemoStart> {

  static EventDemoStart ITypedGameEvent<EventDemoStart>.Create() => new EventDemoStartImpl();

  static string ITypedGameEvent<EventDemoStart>.GetName() => "demo_start";

  static uint ITypedGameEvent<EventDemoStart>.GetHash() => 0x068617A9u;
}
