using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_RandomVector : IParticleFunctionInitializer {

  public ref Vector Min { get; }
  
  public ref Vector Max { get; }
  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public IRandomNumberGeneratorParameters RandomnessParameters { get; }
  
}