using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "store_pricesheet_updated"
/// </summary>
internal class EventStorePricesheetUpdatedImpl : TypedGameEvent<EventStorePricesheetUpdated>, EventStorePricesheetUpdated
{

  public EventStorePricesheetUpdatedImpl(IGameEvent accessor) : base(accessor)
  {
  }
}
