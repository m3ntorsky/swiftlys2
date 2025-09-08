using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_DistanceToNeighborCull : IParticleFunctionInitializer {

  public IPerParticleFloatInput Distance { get; }
  
  public ref bool IncludeRadii { get; }
  
  public IPerParticleFloatInput LifespanOverlap { get; }
  
}