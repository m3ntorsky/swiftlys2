using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmLegacyEvent : INmEvent {

  public ref CUtlString AnimEventClassName { get; }
  
  public ISchemaUntypedField KV { get; }
  
}