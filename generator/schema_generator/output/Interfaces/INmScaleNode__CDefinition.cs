using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmScaleNode__CDefinition : INmPassthroughNode::CDefinition {

  public ref short MaskNodeIdx { get; }
  
  public ref short EnableNodeIdx { get; }
  
}