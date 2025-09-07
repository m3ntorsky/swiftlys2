using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class VertexPositionColor_t : SchemaClass, IVertexPositionColor_t {

  public VertexPositionColor_t(nint handle) : base(handle) {
  }

  public VertexPositionColor_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref Vector Position {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x9E531188BD6A6C9E));
  }


}