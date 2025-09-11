using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmTargetInfoNode__CDefinition : INmFloatValueNode::CDefinition {

  
  public ref short InputValueNodeIdx { get; }
  
  public ref CNmTargetInfoNode::Info_t InfoType { get; }
  
  public ref bool IsWorldSpaceTarget { get; }
}