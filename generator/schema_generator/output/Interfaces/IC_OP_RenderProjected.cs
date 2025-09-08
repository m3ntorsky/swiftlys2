using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RenderProjected : IParticleFunctionRenderer {

  public ref bool ProjectCharacter { get; }
  
  public ref bool ProjectWorld { get; }
  
  public ref bool ProjectWater { get; }
  
  public ref bool FlipHorizontal { get; }
  
  public ref bool EnableProjectedDepthControls { get; }
  
  public ref float MinProjectionDepth { get; }
  
  public ref float MaxProjectionDepth { get; }
  
  public ref CUtlVector ProjectedMaterials { get; }
  
  public IPerParticleFloatInput MaterialSelection { get; }
  
  public ref float AnimationTimeScale { get; }
  
  public ref bool OrientToNormal { get; }
  
  public ref CUtlVector MaterialVars { get; }
  
  public IParticleCollectionFloatInput RadiusScale { get; }
  
  public IParticleCollectionFloatInput AlphaScale { get; }
  
  public IParticleCollectionFloatInput RollScale { get; }
  
  public IParticleAttributeIndex_t Alpha2Field { get; }
  
  public IParticleCollectionVecInput ColorScale { get; }
  
  public ref ParticleColorBlendType_t ColorBlendType { get; }
  
}