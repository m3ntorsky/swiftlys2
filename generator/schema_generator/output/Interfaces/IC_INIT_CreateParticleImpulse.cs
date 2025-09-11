using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_CreateParticleImpulse : IParticleFunctionInitializer {

  
  public IPerParticleFloatInput InputRadius { get; }
  
  public IPerParticleFloatInput InputMagnitude { get; }
  
  public ref ParticleFalloffFunction_t FalloffFunction { get; }
  
  public IPerParticleFloatInput InputFalloffExp { get; }
  
  public ref ParticleImpulseType_t ImpulseType { get; }
}