using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class SkeletonAnimCapture_t__Frame_t : SchemaClass, ISkeletonAnimCapture_t__Frame_t {

  public SkeletonAnimCapture_t__Frame_t(nint handle) : base(handle) {
  }

  public ref float Time {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x413CC2EEC957229E));
  }
  public ISkeletonAnimCapture_t::FrameStamp_t Stamp {
    get => new SkeletonAnimCapture_t::FrameStamp_t(_Handle + Schema.GetOffset(0x413CC2EE11943004));
  }
  public ref CTransform Transform {
    get => ref _Handle.AsRef<CTransform>(Schema.GetOffset(0x413CC2EE6EC5209B));
  }
  public ref bool Teleport {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x413CC2EEE663C11E));
  }
  public ref CUtlVector<CTransform> CompositeBones {
    get => ref _Handle.AsRef<CUtlVector<CTransform>>(Schema.GetOffset(0x413CC2EE5F49062B));
  }
  public ref CUtlVector<CTransform> SimStateBones {
    get => ref _Handle.AsRef<CUtlVector<CTransform>>(Schema.GetOffset(0x413CC2EE5DAE9398));
  }
  public ref CUtlVector<CTransform> FeModelAnims {
    get => ref _Handle.AsRef<CUtlVector<CTransform>>(Schema.GetOffset(0x413CC2EE62EC797D));
  }
  public ref CUtlVector<VectorAligned> FeModelPos {
    get => ref _Handle.AsRef<CUtlVector<VectorAligned>>(Schema.GetOffset(0x413CC2EECA74E7F5));
  }
  public ref CUtlVector<float> FlexControllerWeights {
    get => ref _Handle.AsRef<CUtlVector<float>>(Schema.GetOffset(0x413CC2EECA3D8033));
  }


}