using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SetControlPointToVectorExpression : IParticleFunctionPreEmission {

  
  public ref VectorExpressionType_t Expression { get; }
  
  public ref int OutputCP { get; }
  
  public IParticleCollectionVecInput Input1 { get; }
  
  public IParticleCollectionVecInput Input2 { get; }
  
  public IPerParticleFloatInput Lerp { get; }
  
  public ref bool NormalizedOutput { get; }
}