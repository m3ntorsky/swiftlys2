using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmFloatRemapNode__CDefinition : INmFloatValueNode::CDefinition {

  
  public ref short InputValueNodeIdx { get; }
  
  public INmFloatRemapNode::RemapRange_t InputRange { get; }
  
  public INmFloatRemapNode::RemapRange_t OutputRange { get; }
}