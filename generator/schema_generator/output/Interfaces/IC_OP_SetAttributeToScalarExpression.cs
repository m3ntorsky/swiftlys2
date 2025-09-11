using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SetAttributeToScalarExpression : IParticleFunctionOperator {

  
  public ref ScalarExpressionType_t Expression { get; }
  
  public IPerParticleFloatInput Input1 { get; }
  
  public IPerParticleFloatInput Input2 { get; }
  
  public IParticleRemapFloatInput OutputRemap { get; }
  
  public IParticleAttributeIndex_t OutputField { get; }
  
  public ref ParticleSetMethod_t SetMethod { get; }
}