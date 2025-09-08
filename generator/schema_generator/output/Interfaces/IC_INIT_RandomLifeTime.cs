using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_RandomLifeTime : IParticleFunctionInitializer {

  public ref float LifetimeMin { get; }
  
  public ref float LifetimeMax { get; }
  
  public ref float LifetimeRandExponent { get; }
  
}