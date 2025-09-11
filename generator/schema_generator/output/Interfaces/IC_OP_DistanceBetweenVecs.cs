using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_DistanceBetweenVecs : IParticleFunctionOperator {

  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public IPerParticleVecInput Point1 { get; }
  
  public IPerParticleVecInput Point2 { get; }
  
  public IPerParticleFloatInput InputMin { get; }
  
  public IPerParticleFloatInput InputMax { get; }
  
  public IPerParticleFloatInput OutputMin { get; }
  
  public IPerParticleFloatInput OutputMax { get; }
  
  public ref ParticleSetMethod_t SetMethod { get; }
  
  public ref bool DeltaTime { get; }
}