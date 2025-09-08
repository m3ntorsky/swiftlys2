using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_RandomAlphaWindowThreshold : IParticleFunctionInitializer {

  public ref float Min { get; }
  
  public ref float Max { get; }
  
  public ref float Exponent { get; }
  
}