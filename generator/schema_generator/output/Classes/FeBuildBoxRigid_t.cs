using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeBuildBoxRigid_t : FeBoxRigid_t, IFeBuildBoxRigid_t {

  public FeBuildBoxRigid_t(nint handle) : base(handle) {
  }

  public FeBuildBoxRigid_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int Priority {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x9E8528AFE7EFB335));
  }
  public ref uint VertexMapHash {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x9E8528AF06BCA0A3));
  }
  public ref uint AntitunnelGroupBits {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x9E8528AFA5C6E91A));
  }


}