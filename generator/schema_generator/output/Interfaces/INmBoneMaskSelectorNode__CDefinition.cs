using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmBoneMaskSelectorNode__CDefinition : INmBoneMaskValueNode::CDefinition {

  
  public ref short DefaultMaskNodeIdx { get; }
  
  public ref short ParameterValueNodeIdx { get; }
  
  public ref bool SwitchDynamically { get; }
  
  public ref CUtlVectorFixedGrowable<short> MaskNodeIndices { get; }
  
  public ref CUtlVectorFixedGrowable<CGlobalSymbol> ParameterValues { get; }
  
  public ref float BlendTimeSeconds { get; }
}