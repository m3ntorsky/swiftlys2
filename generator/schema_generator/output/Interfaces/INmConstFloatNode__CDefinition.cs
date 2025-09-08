using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmConstFloatNode__CDefinition : INmFloatValueNode::CDefinition {

  public ref float Value { get; }
  
}