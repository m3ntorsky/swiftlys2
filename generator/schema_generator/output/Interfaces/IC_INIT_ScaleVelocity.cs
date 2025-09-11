using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_ScaleVelocity : IParticleFunctionInitializer {

  
  public IParticleCollectionVecInput Scale { get; }
}