using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_InitFloat : CParticleFunctionInitializer, IC_INIT_InitFloat {

  public C_INIT_InitFloat(nint handle) : base(handle) {
  }

  public C_INIT_InitFloat(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IPerParticleFloatInput InputValue {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x6A1DAB2A34445438));
  }
  public IParticleAttributeIndex_t OutputField {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x6A1DAB2A324F6F74));
  }
  public ref ParticleSetMethod_t SetMethod {
    get => ref _Handle.AsRef<ParticleSetMethod_t>(Schema.GetOffset(0x6A1DAB2AFB53C31E));
  }
  public IPerParticleFloatInput InputStrength {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x6A1DAB2ABAC712FE));
  }


}