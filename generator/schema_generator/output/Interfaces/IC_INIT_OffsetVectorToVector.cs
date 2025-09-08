using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_OffsetVectorToVector : IParticleFunctionInitializer {

  public IParticleAttributeIndex_t FieldInput { get; }
  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public ref Vector OutputMin { get; }
  
  public ref Vector OutputMax { get; }
  
  public IRandomNumberGeneratorParameters RandomnessParameters { get; }
  
}