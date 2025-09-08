using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RenderLightBeam : IParticleFunctionRenderer {

  public IParticleCollectionVecInput ColorBlend { get; }
  
  public ref ParticleColorBlendType_t ColorBlendType { get; }
  
  public IParticleCollectionFloatInput BrightnessLumensPerMeter { get; }
  
  public ref bool CastShadows { get; }
  
  public IParticleCollectionFloatInput Skirt { get; }
  
  public IParticleCollectionFloatInput Range { get; }
  
  public IParticleCollectionFloatInput Thickness { get; }
  
}