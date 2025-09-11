using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmVectorCreateNode__CDefinition : INmVectorValueNode::CDefinition {

  
  public ref short InputVectorValueNodeIdx { get; }
  
  public ref short InputValueXNodeIdx { get; }
  
  public ref short InputValueYNodeIdx { get; }
  
  public ref short InputValueZNodeIdx { get; }
}