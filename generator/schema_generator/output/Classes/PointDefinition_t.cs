using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PointDefinition_t : SchemaClass, IPointDefinition_t {

  public PointDefinition_t(nint handle) : base(handle) {
  }

  public PointDefinition_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int ControlPoint {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x731F83DF0D0DDF8C));
  }
  public ref bool LocalCoords {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x731F83DF30E716DE));
  }
  public ref Vector Offset {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x731F83DFFE159136));
  }


}