using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITextureControls_t : ISchemaClass {

  public IParticleCollectionRendererFloatInput FinalTextureScaleU { get; }
  
  public IParticleCollectionRendererFloatInput FinalTextureScaleV { get; }
  
  public IParticleCollectionRendererFloatInput FinalTextureOffsetU { get; }
  
  public IParticleCollectionRendererFloatInput FinalTextureOffsetV { get; }
  
  public IParticleCollectionRendererFloatInput FinalTextureUVRotation { get; }
  
  public IParticleCollectionRendererFloatInput ZoomScale { get; }
  
  public IParticleCollectionRendererFloatInput Distortion { get; }
  
  public ref bool RandomizeOffsets { get; }
  
  public ref bool ClampUVs { get; }
  
  public ref SpriteCardPerParticleScale_t PerParticleBlend { get; }
  
  public ref SpriteCardPerParticleScale_t PerParticleScale { get; }
  
  public ref SpriteCardPerParticleScale_t PerParticleOffsetU { get; }
  
  public ref SpriteCardPerParticleScale_t PerParticleOffsetV { get; }
  
  public ref SpriteCardPerParticleScale_t PerParticleRotation { get; }
  
  public ref SpriteCardPerParticleScale_t PerParticleZoom { get; }
  
  public ref SpriteCardPerParticleScale_t PerParticleDistortion { get; }
  
}