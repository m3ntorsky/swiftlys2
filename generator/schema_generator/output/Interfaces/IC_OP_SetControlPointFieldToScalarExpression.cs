using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SetControlPointFieldToScalarExpression : IParticleFunctionPreEmission {

  public ref ScalarExpressionType_t Expression { get; }
  
  public IParticleCollectionFloatInput Input1 { get; }
  
  public IParticleCollectionFloatInput Input2 { get; }
  
  public IParticleRemapFloatInput OutputRemap { get; }
  
  public ref int OutputCP { get; }
  
  public ref int OutVectorField { get; }
  
}