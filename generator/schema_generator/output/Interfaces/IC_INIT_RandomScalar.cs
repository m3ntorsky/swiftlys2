using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_RandomScalar : IParticleFunctionInitializer {

  
  public ref float Min { get; }
  
  public ref float Max { get; }
  
  public ref float Exponent { get; }
  
  public IParticleAttributeIndex_t FieldOutput { get; }
}