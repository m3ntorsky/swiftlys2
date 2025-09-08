using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PulseRuntimeCallInfoIndex_t : SchemaClass, IPulseRuntimeCallInfoIndex_t {

  public PulseRuntimeCallInfoIndex_t(nint handle) : base(handle) {
  }

  public ref int Value {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xF715E3DDDCB0894A));
  }


}