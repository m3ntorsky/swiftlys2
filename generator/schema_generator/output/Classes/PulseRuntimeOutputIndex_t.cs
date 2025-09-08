using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PulseRuntimeOutputIndex_t : SchemaClass, IPulseRuntimeOutputIndex_t {

  public PulseRuntimeOutputIndex_t(nint handle) : base(handle) {
  }

  public ref int Value {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x1E8606FEDCB0894A));
  }


}