using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_ScreenSpaceDistanceToEdge : CParticleFunctionOperator, IC_OP_ScreenSpaceDistanceToEdge {

  public C_OP_ScreenSpaceDistanceToEdge(nint handle) : base(handle) {
  }

  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x5525036EE5729606));
  }
  public IPerParticleFloatInput MaxDistFromEdge {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x5525036E3E73EC16));
  }
  public IParticleRemapFloatInput OutputRemap {
    get => new CParticleRemapFloatInput(_Handle + Schema.GetOffset(0x5525036E1239396F));
  }
  public ref ParticleSetMethod_t SetMethod {
    get => ref _Handle.AsRef<ParticleSetMethod_t>(Schema.GetOffset(0x5525036EFB53C31E));
  }


}