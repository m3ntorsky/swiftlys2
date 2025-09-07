using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmBitFlags : SchemaClass, INmBitFlags {

  public CNmBitFlags(nint handle) : base(handle) {
  }

  public CNmBitFlags(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref uint Flags {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x2D0B9CC1DC74A14C));
  }


}