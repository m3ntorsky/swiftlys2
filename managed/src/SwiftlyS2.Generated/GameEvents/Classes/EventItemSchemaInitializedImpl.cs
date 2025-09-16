using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "item_schema_initialized"
/// </summary>
internal class EventItemSchemaInitializedImpl : GameEvent<EventItemSchemaInitialized>, EventItemSchemaInitialized
{

  public EventItemSchemaInitializedImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }
}
