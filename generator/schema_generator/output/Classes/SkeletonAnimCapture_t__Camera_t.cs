using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class SkeletonAnimCapture_t__Camera_t : SchemaClass, ISkeletonAnimCapture_t__Camera_t {

  public SkeletonAnimCapture_t__Camera_t(nint handle) : base(handle) {
  }

  public ref CTransform TmCamera {
    get => ref _Handle.AsRef<CTransform>(Schema.GetOffset(0xEBD053249D7ED559));
  }
  public ref float Time {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xEBD05324C957229E));
  }


}