using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmEntityAttributeIntEvent : INmEntityAttributeEventBase {

  public ref int IntValue { get; }
  
}