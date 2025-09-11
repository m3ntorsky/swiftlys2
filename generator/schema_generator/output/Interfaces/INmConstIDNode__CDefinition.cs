using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmConstIDNode__CDefinition : INmIDValueNode::CDefinition {

  
  public ref CGlobalSymbol Value { get; }
}