using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RemapTransformVisibilityToScalar : IParticleFunctionOperator {

  
  public ref ParticleSetMethod_t SetMethod { get; }
  
  public IParticleTransformInput TransformInput { get; }
  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public ref float InputMin { get; }
  
  public ref float InputMax { get; }
  
  public ref float OutputMin { get; }
  
  public ref float OutputMax { get; }
  
  public ref float Radius { get; }
}