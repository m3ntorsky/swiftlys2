using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_AddVectorToVector : IParticleFunctionInitializer {

  
  public ref Vector Scale { get; }
  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public IParticleAttributeIndex_t FieldInput { get; }
  
  public ref Vector OffsetMin { get; }
  
  public ref Vector OffsetMax { get; }
  
  public IRandomNumberGeneratorParameters RandomnessParameters { get; }
}