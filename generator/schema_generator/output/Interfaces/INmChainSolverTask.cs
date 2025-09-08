using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmChainSolverTask : INmPoseTask {

  public ref int EffectorBoneIdx { get; }
  
  public ref CTransform TargetTransform { get; }
  
  public ref int NumBonesInChain { get; }
  
  public INmTarget EffectorTarget { get; }
  
  public ref NmIKBlendMode_t BlendMode { get; }
  
  public ref float BlendWeight { get; }
  
  public ref bool IsTargetInWorldSpace { get; }
  
  public ref bool IsRunningFromDeserializedData { get; }
  
  public ref CGlobalSymbol DebugEffectorBoneID { get; }
  
  public ref CTransform ChainStartTransformMS { get; }
  
  public ref CTransform DebugRequestedTargetTransformMS { get; }
  
  public ref float DebugTotalChainLength { get; }
  
}