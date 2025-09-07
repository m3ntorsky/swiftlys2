using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PulseCursorYieldToken_t : SchemaClass, IPulseCursorYieldToken_t {

  public PulseCursorYieldToken_t(nint handle) : base(handle) {
  }

  public PulseCursorYieldToken_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int Value {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xBA7B3561DCB0894A));
  }


}