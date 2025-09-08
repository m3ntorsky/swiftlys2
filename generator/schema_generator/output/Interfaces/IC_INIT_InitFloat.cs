using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_InitFloat : IParticleFunctionInitializer {

  public IPerParticleFloatInput InputValue { get; }
  
  public IParticleAttributeIndex_t OutputField { get; }
  
  public ref ParticleSetMethod_t SetMethod { get; }
  
  public IPerParticleFloatInput InputStrength { get; }
  
}