using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "map_transition"
/// </summary>
public interface EventMapTransition : IGameEvent<EventMapTransition> {

  static EventMapTransition IGameEvent<EventMapTransition>.FromAllocated(nint ptr) => new EventMapTransitionImpl(ptr, true);

  static EventMapTransition IGameEvent<EventMapTransition>.FromExternal(nint ptr) => new EventMapTransitionImpl(ptr, false);

  static string IGameEvent<EventMapTransition>.GetName() => "map_transition";

  static uint IGameEvent<EventMapTransition>.GetHash() => 0x75B82729u;
}
