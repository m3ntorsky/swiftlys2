using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SetFloat : IParticleFunctionOperator {

  
  public IPerParticleFloatInput InputValue { get; }
  
  public IParticleAttributeIndex_t OutputField { get; }
  
  public ref ParticleSetMethod_t SetMethod { get; }
  
  public IPerParticleFloatInput Lerp { get; }
}