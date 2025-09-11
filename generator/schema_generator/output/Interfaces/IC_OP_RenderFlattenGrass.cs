using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RenderFlattenGrass : IParticleFunctionRenderer {

  
  public ref float FlattenStrength { get; }
  
  public IParticleAttributeIndex_t StrengthFieldOverride { get; }
  
  public ref float RadiusScale { get; }
}