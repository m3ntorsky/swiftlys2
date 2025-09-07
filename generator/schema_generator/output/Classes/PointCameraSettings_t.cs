using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PointCameraSettings_t : SchemaClass, IPointCameraSettings_t {

  public PointCameraSettings_t(nint handle) : base(handle) {
  }

  public PointCameraSettings_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float NearBlurryDistance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4BE8175CEB0CA47E));
  }
  public ref float NearCrispDistance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4BE8175CF0C9A8C7));
  }
  public ref float FarCrispDistance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4BE8175CE95AEE28));
  }
  public ref float FarBlurryDistance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4BE8175CF8892257));
  }


}