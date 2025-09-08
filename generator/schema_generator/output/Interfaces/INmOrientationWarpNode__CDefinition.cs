using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmOrientationWarpNode__CDefinition : INmPoseNode::CDefinition {

  public ref short ClipReferenceNodeIdx { get; }
  
  public ref short TargetValueNodeIdx { get; }
  
  public ref bool IsOffsetNode { get; }
  
  public ref bool IsOffsetRelativeToCharacter { get; }
  
  public ref CNmRootMotionData::SamplingMode_t SamplingMode { get; }
  
}