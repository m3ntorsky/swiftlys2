using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PulseRuntimeChunkIndex_t : SchemaClass, IPulseRuntimeChunkIndex_t {

  public PulseRuntimeChunkIndex_t(nint handle) : base(handle) {
  }

  public PulseRuntimeChunkIndex_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int Value {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xBC20E682DCB0894A));
  }


}