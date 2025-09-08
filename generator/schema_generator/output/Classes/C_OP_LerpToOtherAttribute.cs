using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_LerpToOtherAttribute : CParticleFunctionOperator, IC_OP_LerpToOtherAttribute {

  public C_OP_LerpToOtherAttribute(nint handle) : base(handle) {
  }

  public IPerParticleFloatInput Interpolation {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x1F92A80BCF55B987));
  }
  public IParticleAttributeIndex_t FieldInputFrom {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x1F92A80BB0E75581));
  }
  public IParticleAttributeIndex_t FieldInput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x1F92A80BAE775669));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x1F92A80BE5729606));
  }


}