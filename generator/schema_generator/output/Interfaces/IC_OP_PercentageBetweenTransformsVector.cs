using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_PercentageBetweenTransformsVector : IParticleFunctionOperator {

  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public ref float InputMin { get; }
  
  public ref float InputMax { get; }
  
  public ref Vector OutputMin { get; }
  
  public ref Vector OutputMax { get; }
  
  public IParticleTransformInput TransformStart { get; }
  
  public IParticleTransformInput TransformEnd { get; }
  
  public ref ParticleSetMethod_t SetMethod { get; }
  
  public ref bool ActiveRange { get; }
  
  public ref bool RadialCheck { get; }
}