using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "item_schema_initialized"
/// </summary>
public interface EventItemSchemaInitialized : ITypedGameEvent<EventItemSchemaInitialized> {

  static EventItemSchemaInitialized ITypedGameEvent<EventItemSchemaInitialized>.Wrap(IGameEvent accessor) => new EventItemSchemaInitializedImpl(accessor);

  static string ITypedGameEvent<EventItemSchemaInitialized>.GetName() => "item_schema_initialized";

  static uint ITypedGameEvent<EventItemSchemaInitialized>.GetHash() => 0x8046CAA1u;
}
