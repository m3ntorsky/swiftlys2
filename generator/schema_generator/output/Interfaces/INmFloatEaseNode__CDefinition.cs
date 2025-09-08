using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmFloatEaseNode__CDefinition : INmFloatValueNode::CDefinition {

  public ref float EaseTime { get; }
  
  public ref float StartValue { get; }
  
  public ref short InputValueNodeIdx { get; }
  
  public ref NmEasingOperation_t EasingOp { get; }
  
  public ref bool UseStartValue { get; }
  
}