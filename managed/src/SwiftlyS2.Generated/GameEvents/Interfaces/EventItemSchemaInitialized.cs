using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "item_schema_initialized"
/// </summary>
public interface EventItemSchemaInitialized : IGameEvent<EventItemSchemaInitialized> {

  static EventItemSchemaInitialized IGameEvent<EventItemSchemaInitialized>.FromAllocated(nint ptr) => new EventItemSchemaInitializedImpl(ptr, true);

  static EventItemSchemaInitialized IGameEvent<EventItemSchemaInitialized>.FromExternal(nint ptr) => new EventItemSchemaInitializedImpl(ptr, false);

  static string IGameEvent<EventItemSchemaInitialized>.GetName() => "item_schema_initialized";

  static uint IGameEvent<EventItemSchemaInitialized>.GetHash() => 0x8046CAA1u;
}
