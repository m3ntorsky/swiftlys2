using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmEntityAttributeEventBase : INmEvent {

  public ref CUtlString AttributeName { get; }
  
}