using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_SetFloatAttributeToVectorExpression : IParticleFunctionInitializer {

  public ref VectorFloatExpressionType_t Expression { get; }
  
  public IPerParticleVecInput Input1 { get; }
  
  public IPerParticleVecInput Input2 { get; }
  
  public IParticleRemapFloatInput OutputRemap { get; }
  
  public IParticleAttributeIndex_t OutputField { get; }
  
  public ref ParticleSetMethod_t SetMethod { get; }
  
}