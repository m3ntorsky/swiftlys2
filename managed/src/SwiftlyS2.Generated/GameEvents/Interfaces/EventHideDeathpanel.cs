using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "hide_deathpanel"
/// </summary>
public interface EventHideDeathpanel : ITypedGameEvent<EventHideDeathpanel> {

  static EventHideDeathpanel ITypedGameEvent<EventHideDeathpanel>.Wrap(IGameEvent accessor) => new EventHideDeathpanelImpl(accessor);

  static string ITypedGameEvent<EventHideDeathpanel>.GetName() => "hide_deathpanel";

  static uint ITypedGameEvent<EventHideDeathpanel>.GetHash() => 0x3B386392u;
}
