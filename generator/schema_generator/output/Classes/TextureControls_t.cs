using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class TextureControls_t : SchemaClass, ITextureControls_t {

  public TextureControls_t(nint handle) : base(handle) {
  }

  public TextureControls_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleCollectionRendererFloatInput FinalTextureScaleU {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0x6019C255986FEDD1));
  }
  public IParticleCollectionRendererFloatInput FinalTextureScaleV {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0x6019C255956FE918));
  }
  public IParticleCollectionRendererFloatInput FinalTextureOffsetU {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0x6019C25524B7447E));
  }
  public IParticleCollectionRendererFloatInput FinalTextureOffsetV {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0x6019C25523B742EB));
  }
  public IParticleCollectionRendererFloatInput FinalTextureUVRotation {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0x6019C2550D61C771));
  }
  public IParticleCollectionRendererFloatInput ZoomScale {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0x6019C25565643B72));
  }
  public IParticleCollectionRendererFloatInput Distortion {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0x6019C25570283608));
  }
  public ref bool RandomizeOffsets {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6019C25541B7E31C));
  }
  public ref bool ClampUVs {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6019C255993F389C));
  }
  public ref SpriteCardPerParticleScale_t PerParticleBlend {
    get => ref _Handle.AsRef<SpriteCardPerParticleScale_t>(Schema.GetOffset(0x6019C25569A29D11));
  }
  public ref SpriteCardPerParticleScale_t PerParticleScale {
    get => ref _Handle.AsRef<SpriteCardPerParticleScale_t>(Schema.GetOffset(0x6019C255E1BE0540));
  }
  public ref SpriteCardPerParticleScale_t PerParticleOffsetU {
    get => ref _Handle.AsRef<SpriteCardPerParticleScale_t>(Schema.GetOffset(0x6019C2559749CC58));
  }
  public ref SpriteCardPerParticleScale_t PerParticleOffsetV {
    get => ref _Handle.AsRef<SpriteCardPerParticleScale_t>(Schema.GetOffset(0x6019C2559A49D111));
  }
  public ref SpriteCardPerParticleScale_t PerParticleRotation {
    get => ref _Handle.AsRef<SpriteCardPerParticleScale_t>(Schema.GetOffset(0x6019C2557AD51358));
  }
  public ref SpriteCardPerParticleScale_t PerParticleZoom {
    get => ref _Handle.AsRef<SpriteCardPerParticleScale_t>(Schema.GetOffset(0x6019C255F0492151));
  }
  public ref SpriteCardPerParticleScale_t PerParticleDistortion {
    get => ref _Handle.AsRef<SpriteCardPerParticleScale_t>(Schema.GetOffset(0x6019C2553A9977DD));
  }


}