using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmIDSelectorNode__CDefinition : INmIDValueNode::CDefinition {

  public ref CUtlVectorFixedGrowable<short> ConditionNodeIndices { get; }
  
  public ref CUtlVectorFixedGrowable<CGlobalSymbol> Values { get; }
  
  public ref CGlobalSymbol DefaultValue { get; }
  
}