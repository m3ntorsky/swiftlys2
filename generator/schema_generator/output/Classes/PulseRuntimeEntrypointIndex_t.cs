using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PulseRuntimeEntrypointIndex_t : SchemaClass, IPulseRuntimeEntrypointIndex_t {

  public PulseRuntimeEntrypointIndex_t(nint handle) : base(handle) {
  }

  public ref int Value {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x5C72FD47DCB0894A));
  }


}