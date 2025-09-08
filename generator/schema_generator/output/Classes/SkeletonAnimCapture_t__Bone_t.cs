using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class SkeletonAnimCapture_t__Bone_t : SchemaClass, ISkeletonAnimCapture_t__Bone_t {

  public SkeletonAnimCapture_t__Bone_t(nint handle) : base(handle) {
  }

  public ref CUtlString Name {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x30D396FDCAE8A266));
  }
  public ref CTransform BindPose {
    get => ref _Handle.AsRef<CTransform>(Schema.GetOffset(0x30D396FDE664FE63));
  }
  public ref int Parent {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x30D396FD0AABB9D1));
  }


}