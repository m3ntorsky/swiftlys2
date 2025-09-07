using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_SetControlPointToPlayer : CParticleFunctionPreEmission, IC_OP_SetControlPointToPlayer {

  public C_OP_SetControlPointToPlayer(nint handle) : base(handle) {
  }

  public C_OP_SetControlPointToPlayer(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int CP1 {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xD877DC8ED4B1E579));
  }
  public ref Vector CP1Pos {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xD877DC8E408288D9));
  }
  public ref bool OrientToEyes {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD877DC8E3270E4F3));
  }


}