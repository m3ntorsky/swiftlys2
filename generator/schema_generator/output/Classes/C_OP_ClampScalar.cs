using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_ClampScalar : CParticleFunctionOperator, IC_OP_ClampScalar {

  public C_OP_ClampScalar(nint handle) : base(handle) {
  }

  public C_OP_ClampScalar(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x2D8090A0E5729606));
  }
  public IPerParticleFloatInput OutputMin {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x2D8090A05F8D7716));
  }
  public IPerParticleFloatInput OutputMax {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x2D8090A051A0E8C4));
  }


}