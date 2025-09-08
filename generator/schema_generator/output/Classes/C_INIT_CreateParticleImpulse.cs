using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_CreateParticleImpulse : CParticleFunctionInitializer, IC_INIT_CreateParticleImpulse {

  public C_INIT_CreateParticleImpulse(nint handle) : base(handle) {
  }

  public IPerParticleFloatInput InputRadius {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x1617EF931F5CA2F9));
  }
  public IPerParticleFloatInput InputMagnitude {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x1617EF938E8975B7));
  }
  public ref ParticleFalloffFunction_t FalloffFunction {
    get => ref _Handle.AsRef<ParticleFalloffFunction_t>(Schema.GetOffset(0x1617EF93A7D5FD7D));
  }
  public IPerParticleFloatInput InputFalloffExp {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x1617EF9356063396));
  }
  public ref ParticleImpulseType_t ImpulseType {
    get => ref _Handle.AsRef<ParticleImpulseType_t>(Schema.GetOffset(0x1617EF9309B21020));
  }


}