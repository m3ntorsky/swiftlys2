using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmFloatRangeComparisonNode__CDefinition : INmBoolValueNode::CDefinition {

  
  public ISchemaUntypedField Range { get; }
  
  public ref short InputValueNodeIdx { get; }
  
  public ref bool IsInclusiveCheck { get; }
}