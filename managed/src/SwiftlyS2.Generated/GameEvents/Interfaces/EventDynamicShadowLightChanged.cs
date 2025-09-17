using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "dynamic_shadow_light_changed"
/// </summary>
public interface EventDynamicShadowLightChanged : ITypedGameEvent<EventDynamicShadowLightChanged> {

  static EventDynamicShadowLightChanged ITypedGameEvent<EventDynamicShadowLightChanged>.Create() => new EventDynamicShadowLightChangedImpl();

  static string ITypedGameEvent<EventDynamicShadowLightChanged>.GetName() => "dynamic_shadow_light_changed";

  static uint ITypedGameEvent<EventDynamicShadowLightChanged>.GetHash() => 0x3FC4330Bu;
}
