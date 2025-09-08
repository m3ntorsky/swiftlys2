using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmIDComparisonNode__CDefinition : INmBoolValueNode::CDefinition {

  public ref short InputValueNodeIdx { get; }
  
  public ref CNmIDComparisonNode::Comparison_t Comparison { get; }
  
  public ref CUtlLeanVectorFixedGrowable<CGlobalSymbol,4> ComparisionIDs { get; }
  
}