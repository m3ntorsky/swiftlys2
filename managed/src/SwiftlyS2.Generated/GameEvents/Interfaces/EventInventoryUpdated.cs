using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "inventory_updated"
/// </summary>
public interface EventInventoryUpdated : ITypedGameEvent<EventInventoryUpdated> {

  static EventInventoryUpdated ITypedGameEvent<EventInventoryUpdated>.Create() => new EventInventoryUpdatedImpl();

  static string ITypedGameEvent<EventInventoryUpdated>.GetName() => "inventory_updated";

  static uint ITypedGameEvent<EventInventoryUpdated>.GetHash() => 0x1EA652FFu;
  /// <summary>
  /// type: short
  /// </summary>
  short ItemDef { get; set; }

  /// <summary>
  /// type: long
  /// </summary>
  int Itemid { get; set; }

}
