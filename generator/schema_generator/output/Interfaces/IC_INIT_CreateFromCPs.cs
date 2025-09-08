using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_CreateFromCPs : IParticleFunctionInitializer {

  public ref int Increment { get; }
  
  public ref int MinCP { get; }
  
  public ref int MaxCP { get; }
  
  public IParticleCollectionFloatInput DynamicCPCount { get; }
  
}