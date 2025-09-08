using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmFixedWeightBoneMaskNode__CDefinition : INmBoneMaskValueNode::CDefinition {

  public ref float BoneWeight { get; }
  
}