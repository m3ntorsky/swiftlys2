using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmClipSelectorNode__CDefinition : INmClipReferenceNode::CDefinition {

  public ref CUtlLeanVectorFixedGrowable<int16,5> OptionNodeIndices { get; }
  
  public ref CUtlLeanVectorFixedGrowable<int16,5> ConditionNodeIndices { get; }
  
}