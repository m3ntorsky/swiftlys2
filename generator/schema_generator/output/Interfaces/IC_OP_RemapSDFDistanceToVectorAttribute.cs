using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RemapSDFDistanceToVectorAttribute : IParticleFunctionOperator {

  public IParticleAttributeIndex_t VectorFieldOutput { get; }
  
  public IParticleAttributeIndex_t VectorFieldInput { get; }
  
  public IParticleCollectionFloatInput MinDistance { get; }
  
  public IParticleCollectionFloatInput MaxDistance { get; }
  
  public ref Vector ValueBelowMin { get; }
  
  public ref Vector ValueAtMin { get; }
  
  public ref Vector ValueAtMax { get; }
  
  public ref Vector ValueAboveMax { get; }
  
}