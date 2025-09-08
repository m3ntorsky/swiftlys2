using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_RandomVectorComponent : IParticleFunctionInitializer {

  public ref float Min { get; }
  
  public ref float Max { get; }
  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public ref int Component { get; }
  
}