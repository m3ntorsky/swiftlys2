using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmPassthroughNode__CDefinition : INmPoseNode::CDefinition {

  public ref short ChildNodeIdx { get; }
  
}