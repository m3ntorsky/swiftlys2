using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmFloatComparisonNode__CDefinition : INmBoolValueNode::CDefinition {

  public ref short InputValueNodeIdx { get; }
  
  public ref short ComparandValueNodeIdx { get; }
  
  public ref CNmFloatComparisonNode::Comparison_t Comparison { get; }
  
  public ref float Epsilon { get; }
  
  public ref float ComparisonValue { get; }
  
}