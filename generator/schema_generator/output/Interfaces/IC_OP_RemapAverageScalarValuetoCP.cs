using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RemapAverageScalarValuetoCP : IParticleFunctionPreEmission {

  public ref SetStatisticExpressionType_t Expression { get; }
  
  public IParticleCollectionFloatInput DecimalPlaces { get; }
  
  public ref int OutControlPointNumber { get; }
  
  public ref int OutVectorField { get; }
  
  public IParticleAttributeIndex_t Field { get; }
  
  public IParticleRemapFloatInput OutputRemap { get; }
  
}