using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmAnimationPoseNode__CDefinition : INmPoseNode::CDefinition {

  public ref short PoseTimeValueNodeIdx { get; }
  
  public ref short DataSlotIdx { get; }
  
  public ISchemaUntypedField InputTimeRemapRange { get; }
  
  public ref float UserSpecifiedTime { get; }
  
  public ref bool UseFramesAsInput { get; }
  
}