using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmIDEventConditionNode__CDefinition : INmBoolValueNode::CDefinition {

  
  public ref short SourceStateNodeIdx { get; }
  
  public INmBitFlags EventConditionRules { get; }
  
  public ref CUtlVectorFixedGrowable<CGlobalSymbol> EventIDs { get; }
}