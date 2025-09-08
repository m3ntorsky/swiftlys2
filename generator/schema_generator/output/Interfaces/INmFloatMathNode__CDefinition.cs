using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmFloatMathNode__CDefinition : INmFloatValueNode::CDefinition {

  public ref short InputValueNodeIdxA { get; }
  
  public ref short InputValueNodeIdxB { get; }
  
  public ref bool ReturnAbsoluteResult { get; }
  
  public ref bool ReturnNegatedResult { get; }
  
  public ref CNmFloatMathNode::Operator_t Operator { get; }
  
  public ref float ValueB { get; }
  
}