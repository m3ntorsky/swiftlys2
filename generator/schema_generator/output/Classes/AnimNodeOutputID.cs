using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class AnimNodeOutputID : SchemaClass, IAnimNodeOutputID {

  public AnimNodeOutputID(nint handle) : base(handle) {
  }

  public AnimNodeOutputID(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref uint Id {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x3873FD84B4B6E980));
  }


}