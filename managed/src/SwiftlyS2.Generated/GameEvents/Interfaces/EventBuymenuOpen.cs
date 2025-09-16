using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "buymenu_open"
/// </summary>
public interface EventBuymenuOpen : IGameEvent<EventBuymenuOpen> {

  static EventBuymenuOpen IGameEvent<EventBuymenuOpen>.FromAllocated(nint ptr) => new EventBuymenuOpenImpl(ptr, true);

  static EventBuymenuOpen IGameEvent<EventBuymenuOpen>.FromExternal(nint ptr) => new EventBuymenuOpenImpl(ptr, false);

  static string IGameEvent<EventBuymenuOpen>.GetName() => "buymenu_open";

  static uint IGameEvent<EventBuymenuOpen>.GetHash() => 0x4DB21865u;
}
