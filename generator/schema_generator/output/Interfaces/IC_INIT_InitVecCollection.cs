using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_InitVecCollection : IParticleFunctionInitializer {

  
  public IParticleCollectionVecInput InputValue { get; }
  
  public IParticleAttributeIndex_t OutputField { get; }
}