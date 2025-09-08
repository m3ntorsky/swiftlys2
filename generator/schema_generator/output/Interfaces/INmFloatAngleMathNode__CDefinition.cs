using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmFloatAngleMathNode__CDefinition : INmFloatValueNode::CDefinition {

  public ref short InputValueNodeIdx { get; }
  
  public ref CNmFloatAngleMathNode::Operation_t Operation { get; }
  
}