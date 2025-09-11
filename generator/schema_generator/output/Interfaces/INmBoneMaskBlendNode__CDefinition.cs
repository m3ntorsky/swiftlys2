using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmBoneMaskBlendNode__CDefinition : INmBoneMaskValueNode::CDefinition {

  
  public ref short SourceMaskNodeIdx { get; }
  
  public ref short TargetMaskNodeIdx { get; }
  
  public ref short BlendWeightValueNodeIdx { get; }
}