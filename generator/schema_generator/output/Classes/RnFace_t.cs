using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class RnFace_t : SchemaClass, IRnFace_t {

  public RnFace_t(nint handle) : base(handle) {
  }

  public RnFace_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref byte Edge {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0xE71D75B3E2949FC8));
  }


}