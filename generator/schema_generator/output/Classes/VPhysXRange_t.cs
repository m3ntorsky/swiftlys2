using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class VPhysXRange_t : SchemaClass, IVPhysXRange_t {

  public VPhysXRange_t(nint handle) : base(handle) {
  }

  public VPhysXRange_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float Min {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x7A251AB33B1A5649));
  }
  public ref float Max {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x7A251AB32D06B887));
  }


}