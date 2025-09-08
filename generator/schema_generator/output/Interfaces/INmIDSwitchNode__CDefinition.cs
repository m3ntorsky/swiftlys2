using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmIDSwitchNode__CDefinition : INmIDValueNode::CDefinition {

  public ref short SwitchValueNodeIdx { get; }
  
  public ref short TrueValueNodeIdx { get; }
  
  public ref short FalseValueNodeIdx { get; }
  
  public ref CGlobalSymbol FalseValue { get; }
  
  public ref CGlobalSymbol TrueValue { get; }
  
}