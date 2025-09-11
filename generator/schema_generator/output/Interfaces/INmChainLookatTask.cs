using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmChainLookatTask : INmPoseTask {

  
  public ref int ChainEndBoneIdx { get; }
  
  public ref int NumBonesInChain { get; }
  
  public ref Vector ChainForwardDir { get; }
  
  public ref float BlendWeight { get; }
  
  public ref float HorizontalAngleLimitDegrees { get; }
  
  public ref float VerticalAngleLimitDegrees { get; }
  
  public ref Vector LookatTarget { get; }
  
  public ref bool IsTargetInWorldSpace { get; }
  
  public ref bool IsRunningFromDeserializedData { get; }
  
  public ref float HorizontalAngleDegrees { get; }
  
  public ref float VerticalAngleDegrees { get; }
}