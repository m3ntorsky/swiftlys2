using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmTransitionNode__CDefinition : INmPoseNode::CDefinition {

  public ref short TargetStateNodeIdx { get; }
  
  public ref short DurationOverrideNodeIdx { get; }
  
  public ref short TimeOffsetOverrideNodeIdx { get; }
  
  public ref short StartBoneMaskNodeIdx { get; }
  
  public ref float Duration { get; }
  
  public INmPercent_t BoneMaskBlendInTimePercentage { get; }
  
  public ref float TimeOffset { get; }
  
  public INmBitFlags TransitionOptions { get; }
  
  public ref short TargetSyncIDNodeIdx { get; }
  
  public ref NmEasingOperation_t BlendWeightEasing { get; }
  
  public ref NmRootMotionBlendMode_t RootMotionBlend { get; }
  
}