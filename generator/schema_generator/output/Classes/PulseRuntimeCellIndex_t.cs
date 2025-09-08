using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PulseRuntimeCellIndex_t : SchemaClass, IPulseRuntimeCellIndex_t {

  public PulseRuntimeCellIndex_t(nint handle) : base(handle) {
  }

  public ref int Value {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x21F81EE9DCB0894A));
  }


}