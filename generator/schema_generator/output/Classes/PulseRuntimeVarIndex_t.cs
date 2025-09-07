using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PulseRuntimeVarIndex_t : SchemaClass, IPulseRuntimeVarIndex_t {

  public PulseRuntimeVarIndex_t(nint handle) : base(handle) {
  }

  public PulseRuntimeVarIndex_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int Value {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xDA229C32DCB0894A));
  }


}