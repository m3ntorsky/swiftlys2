using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CovMatrix3 : SchemaClass, ICovMatrix3 {

  public CovMatrix3(nint handle) : base(handle) {
  }

  public ref Vector Diag {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xA222FA6F7CC0D332));
  }
  public ref float XY {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA222FA6FA58DC304));
  }
  public ref float XZ {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA222FA6FA88DC7BD));
  }
  public ref float YZ {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA222FA6F9E8B7968));
  }


}