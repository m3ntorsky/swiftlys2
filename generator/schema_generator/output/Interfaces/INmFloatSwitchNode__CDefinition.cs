using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmFloatSwitchNode__CDefinition : INmFloatValueNode::CDefinition {

  public ref short SwitchValueNodeIdx { get; }
  
  public ref short TrueValueNodeIdx { get; }
  
  public ref short FalseValueNodeIdx { get; }
  
  public ref float FalseValue { get; }
  
  public ref float TrueValue { get; }
  
}