using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class SkeletonBoneBounds_t : SchemaClass, ISkeletonBoneBounds_t {

  public SkeletonBoneBounds_t(nint handle) : base(handle) {
  }

  public ref Vector Center {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xFF0CF520FA3A6E4));
  }
  public ref Vector Size {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xFF0CF52DABBAEBC));
  }


}