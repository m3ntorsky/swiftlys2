using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmTargetWarpNode__CDefinition : INmPoseNode::CDefinition {

  
  public ref short ClipReferenceNodeIdx { get; }
  
  public ref short TargetValueNodeIdx { get; }
  
  public ref CNmRootMotionData::SamplingMode_t SamplingMode { get; }
  
  public ref bool AllowTargetUpdate { get; }
  
  public ref float SamplingPositionErrorThresholdSq { get; }
  
  public ref float MaxTangentLength { get; }
  
  public ref float LerpFallbackDistanceThreshold { get; }
  
  public ref float TargetUpdateDistanceThreshold { get; }
  
  public ref float TargetUpdateAngleThresholdRadians { get; }
}