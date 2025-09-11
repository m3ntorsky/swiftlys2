using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_InitFromParentKilled : IParticleFunctionInitializer {

  
  public IParticleAttributeIndex_t AttributeToCopy { get; }
  
  public ref EventTypeSelection_t EventType { get; }
}