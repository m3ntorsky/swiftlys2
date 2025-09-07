using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class RnVertex_t : SchemaClass, IRnVertex_t {

  public RnVertex_t(nint handle) : base(handle) {
  }

  public RnVertex_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref byte Edge {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0xA2F56A80E2949FC8));
  }


}