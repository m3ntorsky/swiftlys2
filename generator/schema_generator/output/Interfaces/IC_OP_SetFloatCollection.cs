using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SetFloatCollection : IParticleFunctionOperator {

  
  public IParticleCollectionFloatInput InputValue { get; }
  
  public IParticleAttributeIndex_t OutputField { get; }
  
  public ref ParticleSetMethod_t SetMethod { get; }
  
  public IParticleCollectionFloatInput Lerp { get; }
}