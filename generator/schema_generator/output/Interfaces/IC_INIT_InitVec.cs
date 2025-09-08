using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_InitVec : IParticleFunctionInitializer {

  public IPerParticleVecInput InputValue { get; }
  
  public IParticleAttributeIndex_t OutputField { get; }
  
  public ref ParticleSetMethod_t SetMethod { get; }
  
  public ref bool NormalizedOutput { get; }
  
  public ref bool WritePreviousPosition { get; }
  
}