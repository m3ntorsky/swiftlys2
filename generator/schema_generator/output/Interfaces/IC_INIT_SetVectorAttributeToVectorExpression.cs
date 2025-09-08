using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_SetVectorAttributeToVectorExpression : IParticleFunctionInitializer {

  public ref VectorExpressionType_t Expression { get; }
  
  public IPerParticleVecInput Input1 { get; }
  
  public IPerParticleVecInput Input2 { get; }
  
  public IPerParticleFloatInput Lerp { get; }
  
  public IParticleAttributeIndex_t OutputField { get; }
  
  public ref ParticleSetMethod_t SetMethod { get; }
  
  public ref bool NormalizedOutput { get; }
  
}