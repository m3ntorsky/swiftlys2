using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RemapDensityToVector : IParticleFunctionOperator {

  public ref float RadiusScale { get; }
  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public ref float DensityMin { get; }
  
  public ref float DensityMax { get; }
  
  public ref Vector OutputMin { get; }
  
  public ref Vector OutputMax { get; }
  
  public ref bool UseParentDensity { get; }
  
  public ref int VoxelGridResolution { get; }
  
}