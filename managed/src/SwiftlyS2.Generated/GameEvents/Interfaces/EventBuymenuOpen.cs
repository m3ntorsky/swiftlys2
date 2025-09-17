using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "buymenu_open"
/// </summary>
public interface EventBuymenuOpen : ITypedGameEvent<EventBuymenuOpen> {

  static EventBuymenuOpen ITypedGameEvent<EventBuymenuOpen>.Create() => new EventBuymenuOpenImpl();

  static string ITypedGameEvent<EventBuymenuOpen>.GetName() => "buymenu_open";

  static uint ITypedGameEvent<EventBuymenuOpen>.GetHash() => 0x4DB21865u;
}
