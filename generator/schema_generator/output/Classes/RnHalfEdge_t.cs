using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class RnHalfEdge_t : SchemaClass, IRnHalfEdge_t {

  public RnHalfEdge_t(nint handle) : base(handle) {
  }

  public RnHalfEdge_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref byte Next {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0xB67DE42E8D575D9C));
  }
  public ref byte Twin {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0xB67DE42EF8C9A257));
  }
  public ref byte Origin {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0xB67DE42E57B6C543));
  }
  public ref byte Face {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0xB67DE42EABBCFB38));
  }


}