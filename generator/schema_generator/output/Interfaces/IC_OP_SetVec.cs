using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SetVec : IParticleFunctionOperator {

  
  public IPerParticleVecInput InputValue { get; }
  
  public IParticleAttributeIndex_t OutputField { get; }
  
  public ref ParticleSetMethod_t SetMethod { get; }
  
  public IPerParticleFloatInput Lerp { get; }
  
  public ref bool NormalizedOutput { get; }
}