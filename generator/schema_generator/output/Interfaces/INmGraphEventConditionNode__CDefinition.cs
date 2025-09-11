using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmGraphEventConditionNode__CDefinition : INmBoolValueNode::CDefinition {

  
  public ref short SourceStateNodeIdx { get; }
  
  public INmBitFlags EventConditionRules { get; }
  
// CUtlVectorFixedGrowable< CNmGraphEventConditionNode::Condition_t, 5 >
  public ref CUtlVectorFixedGrowable Conditions { get; }
}