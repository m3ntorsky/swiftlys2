using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class TextureGroup_t : SchemaClass, ITextureGroup_t {

  public TextureGroup_t(nint handle) : base(handle) {
  }

  public ref bool Enabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x3186D8346154EB7E));
  }
  public ref bool ReplaceTextureWithGradient {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x3186D8344E3CBC5A));
  }
  public CStrongHandle<IInfoForResourceTypeCTextureBase> Texture {
    get => new CStrongHandle<InfoForResourceTypeCTextureBase>(_Handle + Schema.GetOffset(0x3186D8348C0A2FB6));
  }
  public ISchemaUntypedField Gradient {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x3186D83405C95F25));
  }
  public ref SpriteCardTextureType_t TextureType {
    get => ref _Handle.AsRef<SpriteCardTextureType_t>(Schema.GetOffset(0x3186D834499BE6C8));
  }
  public ref SpriteCardTextureChannel_t TextureChannels {
    get => ref _Handle.AsRef<SpriteCardTextureChannel_t>(Schema.GetOffset(0x3186D834AB4AA2E8));
  }
  public ref ParticleTextureLayerBlendType_t TextureBlendMode {
    get => ref _Handle.AsRef<ParticleTextureLayerBlendType_t>(Schema.GetOffset(0x3186D83467D79D64));
  }
  public IParticleCollectionRendererFloatInput TextureBlend {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0x3186D8343577569D));
  }
  public ITextureControls_t TextureControls {
    get => new TextureControls_t(_Handle + Schema.GetOffset(0x3186D834AD3B9D2E));
  }


}