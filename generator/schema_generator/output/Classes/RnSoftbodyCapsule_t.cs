using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class RnSoftbodyCapsule_t : SchemaClass, IRnSoftbodyCapsule_t {

  public RnSoftbodyCapsule_t(nint handle) : base(handle) {
  }

  public ISchemaFixedArray<Vector> Center {
    get => new SchemaFixedArray<Vector>(_Handle, 0x896978BC82A5908, 2, 12, 4);
  }
  public ref float Radius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x896978B5ACFC08D));
  }
  public ISchemaFixedArray<ushort> Particle {
    get => new SchemaFixedArray<ushort>(_Handle, 0x896978B863A8E83, 2, 2, 2);
  }


}