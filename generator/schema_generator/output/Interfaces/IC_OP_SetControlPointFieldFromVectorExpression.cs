using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SetControlPointFieldFromVectorExpression : IParticleFunctionPreEmission {

  public ref VectorFloatExpressionType_t Expression { get; }
  
  public IParticleCollectionVecInput Input1 { get; }
  
  public IParticleCollectionVecInput Input2 { get; }
  
  public IPerParticleFloatInput Lerp { get; }
  
  public IParticleRemapFloatInput OutputRemap { get; }
  
  public ref int OutputCP { get; }
  
  public ref int OutVectorField { get; }
  
}