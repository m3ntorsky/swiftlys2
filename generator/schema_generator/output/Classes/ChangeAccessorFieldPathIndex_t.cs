using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class ChangeAccessorFieldPathIndex_t : SchemaClass, IChangeAccessorFieldPathIndex_t {

  public ChangeAccessorFieldPathIndex_t(nint handle) : base(handle) {
  }

  public ChangeAccessorFieldPathIndex_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int Value {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x951C0630DCB0894A));
  }


}