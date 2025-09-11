using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmFloatSelectorNode__CDefinition : INmFloatValueNode::CDefinition {

  
  public ref CUtlVectorFixedGrowable<short> ConditionNodeIndices { get; }
  
  public ref CUtlVectorFixedGrowable<float> Values { get; }
  
  public ref float DefaultValue { get; }
  
  public ref float EaseTime { get; }
  
  public ref NmEasingOperation_t EasingOp { get; }
}