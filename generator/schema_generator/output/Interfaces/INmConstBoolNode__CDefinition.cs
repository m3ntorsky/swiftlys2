using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmConstBoolNode__CDefinition : INmBoolValueNode::CDefinition {

  public ref bool Value { get; }
  
}