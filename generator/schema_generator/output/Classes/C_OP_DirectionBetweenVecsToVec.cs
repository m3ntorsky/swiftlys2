using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_DirectionBetweenVecsToVec : CParticleFunctionOperator, IC_OP_DirectionBetweenVecsToVec {

  public C_OP_DirectionBetweenVecsToVec(nint handle) : base(handle) {
  }

  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x6022BA82E5729606));
  }
  public IPerParticleVecInput Point1 {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0x6022BA8204AD2BC0));
  }
  public IPerParticleVecInput Point2 {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0x6022BA8207AD3079));
  }


}