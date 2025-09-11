using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmFloatCurveEventNode__CDefinition : INmFloatValueNode::CDefinition {

  
  public ref CGlobalSymbol EventID { get; }
  
  public ref short DefaultNodeIdx { get; }
  
  public ref float DefaultValue { get; }
  
  public INmBitFlags EventConditionRules { get; }
}