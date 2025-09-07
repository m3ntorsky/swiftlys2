using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class RnSoftbodyCapsule_t : SchemaClass, IRnSoftbodyCapsule_t {

  public RnSoftbodyCapsule_t(nint handle) : base(handle) {
  }

  public RnSoftbodyCapsule_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaFixedArray<Vector> Center {
    get => new SchemaFixedArray<Vector>(_Handle + Schema.GetOffset(0x896978BC82A5908));
  }
  public ref float Radius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x896978B5ACFC08D));
  }
  public ISchemaFixedArray<uint16> Particle {
    get => new SchemaFixedArray<uint16>(_Handle + Schema.GetOffset(0x896978B863A8E83));
  }


}