using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_SetControlPointToCenter : CParticleFunctionPreEmission, IC_OP_SetControlPointToCenter {

  public C_OP_SetControlPointToCenter(nint handle) : base(handle) {
  }

  public ref int CP1 {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xB2CEB7C2D4B1E579));
  }
  public ref Vector CP1Pos {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xB2CEB7C2408288D9));
  }
  public ref bool UseAvgParticlePos {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xB2CEB7C2399CEECC));
  }
  public ref ParticleParentSetMode_t SetParent {
    get => ref _Handle.AsRef<ParticleParentSetMode_t>(Schema.GetOffset(0xB2CEB7C22D8246B7));
  }


}