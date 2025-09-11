using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_DirectionBetweenVecsToVec : IParticleFunctionOperator {

  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public IPerParticleVecInput Point1 { get; }
  
  public IPerParticleVecInput Point2 { get; }
}