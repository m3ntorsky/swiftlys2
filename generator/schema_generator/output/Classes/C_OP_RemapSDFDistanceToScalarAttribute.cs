using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RemapSDFDistanceToScalarAttribute : CParticleFunctionOperator, IC_OP_RemapSDFDistanceToScalarAttribute {

  public C_OP_RemapSDFDistanceToScalarAttribute(nint handle) : base(handle) {
  }

  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x94CC5381E5729606));
  }
  public IParticleAttributeIndex_t VectorFieldInput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x94CC5381588D910E));
  }
  public IParticleCollectionFloatInput MinDistance {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x94CC538192BCAD06));
  }
  public IParticleCollectionFloatInput MaxDistance {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x94CC538198893360));
  }
  public IParticleCollectionFloatInput ValueBelowMin {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x94CC538154034C2B));
  }
  public IParticleCollectionFloatInput ValueAtMin {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x94CC53814B125A6B));
  }
  public IParticleCollectionFloatInput ValueAtMax {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x94CC538160FEF555));
  }
  public IParticleCollectionFloatInput ValueAboveMax {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x94CC538139F292C1));
  }


}