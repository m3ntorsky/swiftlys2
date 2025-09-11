using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmCurrentSyncEventNode__CDefinition : INmFloatValueNode::CDefinition {

  
  public ref short SourceStateNodeIdx { get; }
  
  public ref CNmCurrentSyncEventNode::InfoType_t InfoType { get; }
}