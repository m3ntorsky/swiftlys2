using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmClip : ISchemaClass {

  public CStrongHandle<IInfoForResourceTypeCNmSkeleton> Skeleton { get; }
  
  public ref uint NumFrames { get; }
  
  public ref float Duration { get; }
  
  public ref CUtlBinaryBlock CompressedPoseData { get; }
  
  public ref CUtlVector TrackCompressionSettings { get; }
  
  public ref CUtlVector<uint> CompressedPoseOffsets { get; }
  
  public ref CUtlVectorFixedGrowable<PointerTo<CNmClip>> SecondaryAnimations { get; }
  
  public INmSyncTrack SyncTrack { get; }
  
  public INmRootMotionData RootMotion { get; }
  
  public ref bool IsAdditive { get; }
  
  public ref CUtlVector ModelSpaceSamplingChain { get; }
  
  public ref CUtlVector<int> ModelSpaceBoneSamplingIndices { get; }
  
}