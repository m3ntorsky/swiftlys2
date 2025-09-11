using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_Orient2DRelToCP : IParticleFunctionInitializer {

  
  public ref int CP { get; }
  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public ref float RotOffset { get; }
}