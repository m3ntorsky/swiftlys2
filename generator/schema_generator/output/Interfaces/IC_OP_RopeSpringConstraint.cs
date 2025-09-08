using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RopeSpringConstraint : IParticleFunctionConstraint {

  public IParticleCollectionFloatInput RestLength { get; }
  
  public IParticleCollectionFloatInput MinDistance { get; }
  
  public IParticleCollectionFloatInput MaxDistance { get; }
  
  public ref float AdjustmentScale { get; }
  
  public IParticleCollectionFloatInput InitialRestingLength { get; }
  
}