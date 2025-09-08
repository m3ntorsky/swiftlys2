using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RemapParticleCountToScalar : IParticleFunctionOperator {

  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public IParticleCollectionFloatInput InputMin { get; }
  
  public IParticleCollectionFloatInput InputMax { get; }
  
  public IParticleCollectionFloatInput OutputMin { get; }
  
  public IParticleCollectionFloatInput OutputMax { get; }
  
  public ref bool ActiveRange { get; }
  
  public ref ParticleSetMethod_t SetMethod { get; }
  
}