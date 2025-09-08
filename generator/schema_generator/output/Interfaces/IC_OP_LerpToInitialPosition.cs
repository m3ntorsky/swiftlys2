using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_LerpToInitialPosition : IParticleFunctionOperator {

  public ref int ControlPointNumber { get; }
  
  public IPerParticleFloatInput Interpolation { get; }
  
  public IParticleAttributeIndex_t CacheField { get; }
  
  public IParticleCollectionFloatInput Scale { get; }
  
  public IParticleCollectionVecInput Scale { get; }
  
}