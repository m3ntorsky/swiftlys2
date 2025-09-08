using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmCurrentSyncEventIDNode__CDefinition : INmIDValueNode::CDefinition {

  public ref short SourceStateNodeIdx { get; }
  
}