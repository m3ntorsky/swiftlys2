using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmOrNode__CDefinition : INmBoolValueNode::CDefinition {

  
  public ref CUtlLeanVectorFixedGrowable<int16,4> ConditionNodeIndices { get; }
}