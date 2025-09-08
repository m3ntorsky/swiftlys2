using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class RnPlane_t : SchemaClass, IRnPlane_t {

  public RnPlane_t(nint handle) : base(handle) {
  }

  public ref Vector Normal {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xEAF5B7BAAFB36E96));
  }
  public ref float Offset {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xEAF5B7BA7F14BA34));
  }


}