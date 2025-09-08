using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_RandomTrailLength : IParticleFunctionInitializer {

  public ref float MinLength { get; }
  
  public ref float MaxLength { get; }
  
  public ref float LengthRandExponent { get; }
  
}