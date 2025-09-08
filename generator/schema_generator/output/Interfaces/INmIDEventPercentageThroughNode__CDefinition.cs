using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmIDEventPercentageThroughNode__CDefinition : INmBoolValueNode::CDefinition {

  public ref short SourceStateNodeIdx { get; }
  
  public INmBitFlags EventConditionRules { get; }
  
  public ref CGlobalSymbol EventID { get; }
  
}