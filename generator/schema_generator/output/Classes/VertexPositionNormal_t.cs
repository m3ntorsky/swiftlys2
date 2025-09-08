using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class VertexPositionNormal_t : SchemaClass, IVertexPositionNormal_t {

  public VertexPositionNormal_t(nint handle) : base(handle) {
  }

  public ref Vector Position {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x47BDE764BD6A6C9E));
  }
  public ref Vector Normal {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x47BDE764AFB36E96));
  }


}