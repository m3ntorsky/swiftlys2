using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmConstVectorNode__CDefinition : INmVectorValueNode::CDefinition {

  
  public ref Vector Value { get; }
}