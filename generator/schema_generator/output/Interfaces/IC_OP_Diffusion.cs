using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_Diffusion : IParticleFunctionOperator {

  
  public ref float RadiusScale { get; }
  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public ref int VoxelGridResolution { get; }
}