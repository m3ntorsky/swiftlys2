using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSkeletonAnimationController : ISkeletonAnimationController, ISkeletonAnimationController {

  public CSkeletonAnimationController(nint handle) : base(handle) {
  }

  public CSkeletonAnimationController(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISkeletonInstance SkeletonInstance {
    get => new CSkeletonInstance(_Handle + Schema.GetOffset(0x47164D01F28853));
  }


}