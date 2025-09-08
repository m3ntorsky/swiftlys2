using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmTargetPointNode__CDefinition : INmVectorValueNode::CDefinition {

  public ref short InputValueNodeIdx { get; }
  
  public ref bool IsWorldSpaceTarget { get; }
  
}