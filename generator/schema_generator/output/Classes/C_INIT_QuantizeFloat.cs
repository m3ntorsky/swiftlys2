using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_QuantizeFloat : CParticleFunctionInitializer, IC_INIT_QuantizeFloat {

  public C_INIT_QuantizeFloat(nint handle) : base(handle) {
  }

  public IPerParticleFloatInput InputValue {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x1A8E56B534445438));
  }
  public IParticleAttributeIndex_t OutputField {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x1A8E56B5324F6F74));
  }


}