using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_ClampVector : CParticleFunctionOperator, IC_OP_ClampVector {

  public C_OP_ClampVector(nint handle) : base(handle) {
  }

  public C_OP_ClampVector(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x5977BF1BE5729606));
  }
  public IPerParticleVecInput OutputMin {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0x5977BF1B2EFED678));
  }
  public IPerParticleVecInput OutputMax {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0x5977BF1B451280D2));
  }


}