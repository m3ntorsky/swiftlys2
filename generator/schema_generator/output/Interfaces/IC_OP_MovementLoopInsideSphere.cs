using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_MovementLoopInsideSphere : IParticleFunctionOperator {

  public ref int CP { get; }
  
  public IParticleCollectionFloatInput Distance { get; }
  
  public IParticleCollectionVecInput Scale { get; }
  
  public IParticleAttributeIndex_t DistSqrAttr { get; }
  
}