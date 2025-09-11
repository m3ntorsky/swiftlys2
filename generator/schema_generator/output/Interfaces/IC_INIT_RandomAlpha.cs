using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_RandomAlpha : IParticleFunctionInitializer {

  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public ref int AlphaMin { get; }
  
  public ref int AlphaMax { get; }
  
  public ref float AlphaRandExponent { get; }
}