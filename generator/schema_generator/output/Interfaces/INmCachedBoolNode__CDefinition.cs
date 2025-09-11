using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmCachedBoolNode__CDefinition : INmBoolValueNode::CDefinition {

  
  public ref short InputValueNodeIdx { get; }
  
  public ref NmCachedValueMode_t Mode { get; }
}