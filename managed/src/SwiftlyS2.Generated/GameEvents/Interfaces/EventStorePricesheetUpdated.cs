using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "store_pricesheet_updated"
/// </summary>
public interface EventStorePricesheetUpdated : ITypedGameEvent<EventStorePricesheetUpdated> {

  static EventStorePricesheetUpdated ITypedGameEvent<EventStorePricesheetUpdated>.Create() => new EventStorePricesheetUpdatedImpl();

  static string ITypedGameEvent<EventStorePricesheetUpdated>.GetName() => "store_pricesheet_updated";

  static uint ITypedGameEvent<EventStorePricesheetUpdated>.GetHash() => 0xE425C0FFu;
}
