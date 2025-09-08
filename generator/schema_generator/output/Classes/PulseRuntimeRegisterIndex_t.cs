using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PulseRuntimeRegisterIndex_t : SchemaClass, IPulseRuntimeRegisterIndex_t {

  public PulseRuntimeRegisterIndex_t(nint handle) : base(handle) {
  }

  public ref short Value {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x9EE6795EDCB0894A));
  }


}