using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SDFConstraint : IParticleFunctionConstraint {

  
  public IParticleCollectionFloatInput MinDist { get; }
  
  public IParticleCollectionFloatInput MaxDist { get; }
  
  public ref int MaxIterations { get; }
}