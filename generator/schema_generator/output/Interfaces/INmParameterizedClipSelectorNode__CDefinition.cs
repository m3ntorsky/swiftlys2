using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmParameterizedClipSelectorNode__CDefinition : INmClipReferenceNode::CDefinition {

  public ref CUtlLeanVectorFixedGrowable<int16,5> OptionNodeIndices { get; }
  
  public ref CUtlLeanVectorFixedGrowable<uint8,5> OptionWeights { get; }
  
  public ref short ParameterNodeIdx { get; }
  
  public ref bool IgnoreInvalidOptions { get; }
  
  public ref bool HasWeightsSet { get; }
  
}