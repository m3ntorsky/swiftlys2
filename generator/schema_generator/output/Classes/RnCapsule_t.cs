using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class RnCapsule_t : SchemaClass, IRnCapsule_t {

  public RnCapsule_t(nint handle) : base(handle) {
  }

  public ISchemaFixedArray<Vector> Center {
    get => new SchemaFixedArray<Vector>(_Handle, 0xA2412C03C82A5908, 2, 12, 4);
  }
  public ref float Radius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA2412C035ACFC08D));
  }


}