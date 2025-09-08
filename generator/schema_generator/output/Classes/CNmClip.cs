using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmClip : SchemaClass, INmClip {

  public CNmClip(nint handle) : base(handle) {
  }

  public CStrongHandle<IInfoForResourceTypeCNmSkeleton> Skeleton {
    get => new CStrongHandle<InfoForResourceTypeCNmSkeleton>(_Handle + Schema.GetOffset(0x3FC883BDE77F030E));
  }
  public ref uint NumFrames {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x3FC883BDF764C355));
  }
  public ref float Duration {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x3FC883BDBC5E3BAB));
  }
  public ref CUtlBinaryBlock CompressedPoseData {
    get => ref _Handle.AsRef<CUtlBinaryBlock>(Schema.GetOffset(0x3FC883BDDD916D11));
  }
  public ref CUtlVector TrackCompressionSettings {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x3FC883BD94A50263));
  }
  public ref CUtlVector<uint> CompressedPoseOffsets {
    get => ref _Handle.AsRef<CUtlVector<uint>>(Schema.GetOffset(0x3FC883BD4B1ECAF7));
  }
  public ref CUtlVectorFixedGrowable<PointerTo<CNmClip>> SecondaryAnimations {
    get => ref _Handle.AsRef<CUtlVectorFixedGrowable<PointerTo<CNmClip>>>(Schema.GetOffset(0x3FC883BD9A6B439E));
  }
  public INmSyncTrack SyncTrack {
    get => new CNmSyncTrack(_Handle + Schema.GetOffset(0x3FC883BDB268BEE9));
  }
  public INmRootMotionData RootMotion {
    get => new CNmRootMotionData(_Handle + Schema.GetOffset(0x3FC883BD664A3F27));
  }
  public ref bool IsAdditive {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x3FC883BD4146EEF5));
  }
  public ref CUtlVector ModelSpaceSamplingChain {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x3FC883BD54666BDA));
  }
  public ref CUtlVector<int> ModelSpaceBoneSamplingIndices {
    get => ref _Handle.AsRef<CUtlVector<int>>(Schema.GetOffset(0x3FC883BD197B4A28));
  }


}