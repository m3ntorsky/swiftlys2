using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_PercentageBetweenTransformLerpCPs : IParticleFunctionOperator {

  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public ref float InputMin { get; }
  
  public ref float InputMax { get; }
  
  public IParticleTransformInput TransformStart { get; }
  
  public IParticleTransformInput TransformEnd { get; }
  
  public ref int OutputStartCP { get; }
  
  public ref int OutputStartField { get; }
  
  public ref int OutputEndCP { get; }
  
  public ref int OutputEndField { get; }
  
  public ref ParticleSetMethod_t SetMethod { get; }
  
  public ref bool ActiveRange { get; }
  
  public ref bool RadialCheck { get; }
}