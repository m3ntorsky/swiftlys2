using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmVectorInfoNode__CDefinition : INmFloatValueNode::CDefinition {

  public ref short InputValueNodeIdx { get; }
  
  public ref CNmVectorInfoNode::Info_t DesiredInfo { get; }
  
}