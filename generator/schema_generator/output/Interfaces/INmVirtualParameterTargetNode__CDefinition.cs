using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmVirtualParameterTargetNode__CDefinition : INmTargetValueNode::CDefinition {

  public ref short ChildNodeIdx { get; }
  
}