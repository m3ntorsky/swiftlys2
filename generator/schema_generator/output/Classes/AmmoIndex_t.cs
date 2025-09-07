using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class AmmoIndex_t : SchemaClass, IAmmoIndex_t {

  public AmmoIndex_t(nint handle) : base(handle) {
  }

  public AmmoIndex_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref byte Value {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x47E6281EDCB0894A));
  }


}