using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_CylindricalDistanceToTransform : IParticleFunctionOperator {

  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public IPerParticleFloatInput InputMin { get; }
  
  public IPerParticleFloatInput InputMax { get; }
  
  public IPerParticleFloatInput OutputMin { get; }
  
  public IPerParticleFloatInput OutputMax { get; }
  
  public IParticleTransformInput TransformStart { get; }
  
  public IParticleTransformInput TransformEnd { get; }
  
  public ref ParticleSetMethod_t SetMethod { get; }
  
  public ref bool ActiveRange { get; }
  
  public ref bool Additive { get; }
  
  public ref bool Capsule { get; }
}