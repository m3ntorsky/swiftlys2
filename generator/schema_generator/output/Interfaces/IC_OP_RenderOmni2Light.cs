using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RenderOmni2Light : IParticleFunctionRenderer {

  public ref ParticleOmni2LightTypeChoiceList_t LightType { get; }
  
  public IParticleCollectionVecInput ColorBlend { get; }
  
  public ref ParticleColorBlendType_t ColorBlendType { get; }
  
  public ref ParticleLightUnitChoiceList_t BrightnessUnit { get; }
  
  public IPerParticleFloatInput BrightnessLumens { get; }
  
  public IPerParticleFloatInput BrightnessCandelas { get; }
  
  public ref bool CastShadows { get; }
  
  public ref bool Fog { get; }
  
  public IPerParticleFloatInput FogScale { get; }
  
  public IPerParticleFloatInput LuminaireRadius { get; }
  
  public IPerParticleFloatInput Skirt { get; }
  
  public IPerParticleFloatInput Range { get; }
  
  public IPerParticleFloatInput InnerConeAngle { get; }
  
  public IPerParticleFloatInput OuterConeAngle { get; }
  
  public ref CStrongHandle<InfoForResourceTypeCTextureBase> LightCookie { get; }
  
  public ref bool SphericalCookie { get; }
  
}