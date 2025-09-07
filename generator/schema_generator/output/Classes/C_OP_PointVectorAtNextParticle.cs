using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_PointVectorAtNextParticle : CParticleFunctionOperator, IC_OP_PointVectorAtNextParticle {

  public C_OP_PointVectorAtNextParticle(nint handle) : base(handle) {
  }

  public C_OP_PointVectorAtNextParticle(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xC209094CE5729606));
  }
  public IPerParticleFloatInput Interpolation {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xC209094CCF55B987));
  }


}