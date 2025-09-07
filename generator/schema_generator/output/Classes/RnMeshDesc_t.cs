using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class RnMeshDesc_t : RnShapeDesc_t, IRnMeshDesc_t {

  public RnMeshDesc_t(nint handle) : base(handle) {
  }

  public RnMeshDesc_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IRnMesh_t Mesh {
    get => new RnMesh_t(_Handle + Schema.GetOffset(0xB236F002DEAFA33C));
  }


}