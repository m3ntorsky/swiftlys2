using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RemapSDFDistanceToScalarAttribute : IParticleFunctionOperator {

  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public IParticleAttributeIndex_t VectorFieldInput { get; }
  
  public IParticleCollectionFloatInput MinDistance { get; }
  
  public IParticleCollectionFloatInput MaxDistance { get; }
  
  public IParticleCollectionFloatInput ValueBelowMin { get; }
  
  public IParticleCollectionFloatInput ValueAtMin { get; }
  
  public IParticleCollectionFloatInput ValueAtMax { get; }
  
  public IParticleCollectionFloatInput ValueAboveMax { get; }
}