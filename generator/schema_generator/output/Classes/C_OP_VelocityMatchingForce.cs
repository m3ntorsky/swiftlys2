using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_VelocityMatchingForce : CParticleFunctionOperator, IC_OP_VelocityMatchingForce {

  public C_OP_VelocityMatchingForce(nint handle) : base(handle) {
  }

  public C_OP_VelocityMatchingForce(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float DirScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8B7E85343A95212C));
  }
  public ref float SpdScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8B7E8534B3DC18DA));
  }
  public ref float NeighborDistance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8B7E8534F03C7C66));
  }
  public ref float FacingStrength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8B7E85340D514274));
  }
  public ref bool UseAABB {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x8B7E853429AAFF2E));
  }
  public ref int CPBroadcast {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x8B7E85344C1065B5));
  }


}