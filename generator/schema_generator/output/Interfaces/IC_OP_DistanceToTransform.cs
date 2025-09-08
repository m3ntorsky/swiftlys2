using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_DistanceToTransform : IParticleFunctionOperator {

  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public IPerParticleFloatInput InputMin { get; }
  
  public IPerParticleFloatInput InputMax { get; }
  
  public IPerParticleFloatInput OutputMin { get; }
  
  public IPerParticleFloatInput OutputMax { get; }
  
  public IParticleTransformInput TransformStart { get; }
  
  public ref bool LOS { get; }
  
  public ISchemaFixedString CollisionGroupName { get; }
  
  public ref ParticleTraceSet_t TraceSet { get; }
  
  public ref float MaxTraceLength { get; }
  
  public ref float LOSScale { get; }
  
  public ref ParticleSetMethod_t SetMethod { get; }
  
  public ref bool ActiveRange { get; }
  
  public ref bool Additive { get; }
  
  public IPerParticleVecInput ComponentScale { get; }
  
}