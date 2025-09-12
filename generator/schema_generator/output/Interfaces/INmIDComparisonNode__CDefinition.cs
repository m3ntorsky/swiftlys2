using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmIDComparisonNode__CDefinition : INmBoolValueNode::CDefinition {

  
  public ref short InputValueNodeIdx { get; }
  
  public ref CNmIDComparisonNode::Comparison_t Comparison { get; }
  
  public ISchemaUntypedField ComparisionIDs { get; }
}