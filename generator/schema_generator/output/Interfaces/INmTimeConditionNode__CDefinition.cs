using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmTimeConditionNode__CDefinition : INmBoolValueNode::CDefinition {

  public ref short SourceStateNodeIdx { get; }
  
  public ref short InputValueNodeIdx { get; }
  
  public ref float Comparand { get; }
  
  public ref CNmTimeConditionNode::ComparisonType_t Type { get; }
  
  public ref CNmTimeConditionNode::Operator_t Operator { get; }
  
}