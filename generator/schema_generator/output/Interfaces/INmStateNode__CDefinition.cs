using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmStateNode__CDefinition : INmPoseNode::CDefinition {

  public ref short ChildNodeIdx { get; }
  
  public ref CUtlLeanVectorFixedGrowable<CGlobalSymbol,3> EntryEvents { get; }
  
  public ref CUtlLeanVectorFixedGrowable<CGlobalSymbol,3> ExecuteEvents { get; }
  
  public ref CUtlLeanVectorFixedGrowable<CGlobalSymbol,3> ExitEvents { get; }
  
  public ref CUtlLeanVectorFixedGrowable<CNmStateNode::TimedEvent_t,1> TimedRemainingEvents { get; }
  
  public ref CUtlLeanVectorFixedGrowable<CNmStateNode::TimedEvent_t,1> TimedElapsedEvents { get; }
  
  public ref short LayerWeightNodeIdx { get; }
  
  public ref short LayerRootMotionWeightNodeIdx { get; }
  
  public ref short LayerBoneMaskNodeIdx { get; }
  
  public ref bool IsOffState { get; }
  
}