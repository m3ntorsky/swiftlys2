using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PulseRuntimeStateOffset_t : SchemaClass, IPulseRuntimeStateOffset_t {

  public PulseRuntimeStateOffset_t(nint handle) : base(handle) {
  }

  public ref ushort Value {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x6DB06DE3DCB0894A));
  }


}