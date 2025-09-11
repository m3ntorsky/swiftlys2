using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmFootstepEventIDNode__CDefinition : INmIDValueNode::CDefinition {

  
  public ref short SourceStateNodeIdx { get; }
  
  public INmBitFlags EventConditionRules { get; }
}