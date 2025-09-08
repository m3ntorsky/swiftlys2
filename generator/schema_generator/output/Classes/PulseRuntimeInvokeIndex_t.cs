using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PulseRuntimeInvokeIndex_t : SchemaClass, IPulseRuntimeInvokeIndex_t {

  public PulseRuntimeInvokeIndex_t(nint handle) : base(handle) {
  }

  public ref int Value {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xEFA175D1DCB0894A));
  }


}