using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmAimCSNode__CDefinition : INmPassthroughNode::CDefinition {

  public ref short VerticalAngleNodeIdx { get; }
  
  public ref short HorizontalAngleNodeIdx { get; }
  
  public ref short EnabledNodeIdx { get; }
  
  public ref float BlendTimeSeconds { get; }
  
}