using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "map_transition"
/// </summary>
public interface EventMapTransition : ITypedGameEvent<EventMapTransition> {

  static EventMapTransition ITypedGameEvent<EventMapTransition>.Create() => new EventMapTransitionImpl();

  static string ITypedGameEvent<EventMapTransition>.GetName() => "map_transition";

  static uint ITypedGameEvent<EventMapTransition>.GetHash() => 0x75B82729u;
}
