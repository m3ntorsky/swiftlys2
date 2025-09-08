using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeBuildSphereRigid_t : FeSphereRigid_t, IFeBuildSphereRigid_t {

  public FeBuildSphereRigid_t(nint handle) : base(handle) {
  }

  public ref int Priority {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xB0A01B13E7EFB335));
  }
  public ref uint VertexMapHash {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xB0A01B1306BCA0A3));
  }
  public ref uint AntitunnelGroupBits {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xB0A01B13A5C6E91A));
  }


}