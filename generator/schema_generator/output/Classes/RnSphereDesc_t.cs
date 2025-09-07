using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class RnSphereDesc_t : RnShapeDesc_t, IRnSphereDesc_t {

  public RnSphereDesc_t(nint handle) : base(handle) {
  }

  public RnSphereDesc_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaUntypedField Sphere {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x6187F5E1E7A3D98));
  }


}