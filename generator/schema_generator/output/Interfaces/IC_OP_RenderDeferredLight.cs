using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RenderDeferredLight : IParticleFunctionRenderer {

  public ref bool UseAlphaTestWindow { get; }
  
  public ref bool UseTexture { get; }
  
  public ref float RadiusScale { get; }
  
  public ref float AlphaScale { get; }
  
  public IParticleAttributeIndex_t Alpha2Field { get; }
  
  public IParticleCollectionVecInput ColorScale { get; }
  
  public ref ParticleColorBlendType_t ColorBlendType { get; }
  
  public ref float LightDistance { get; }
  
  public ref float StartFalloff { get; }
  
  public ref float DistanceFalloff { get; }
  
  public ref float SpotFoV { get; }
  
  public IParticleAttributeIndex_t AlphaTestPointField { get; }
  
  public IParticleAttributeIndex_t AlphaTestRangeField { get; }
  
  public IParticleAttributeIndex_t AlphaTestSharpnessField { get; }
  
  public CStrongHandle<IInfoForResourceTypeCTextureBase> Texture { get; }
  
  public ref int HSVShiftControlPoint { get; }
  
}