using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_RandomRadius : IParticleFunctionInitializer {

  
  public ref float RadiusMin { get; }
  
  public ref float RadiusMax { get; }
  
  public ref float RadiusRandExponent { get; }
}