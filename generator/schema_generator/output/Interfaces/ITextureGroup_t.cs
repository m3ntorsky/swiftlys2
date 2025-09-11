using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITextureGroup_t : ISchemaClass {

  
  public ref bool Enabled { get; }
  
  public ref bool ReplaceTextureWithGradient { get; }
  
  public ref CStrongHandle<InfoForResourceTypeCTextureBase> Texture { get; }
  
  public ISchemaUntypedField Gradient { get; }
  
  public ref SpriteCardTextureType_t TextureType { get; }
  
  public ref SpriteCardTextureChannel_t TextureChannels { get; }
  
  public ref ParticleTextureLayerBlendType_t TextureBlendMode { get; }
  
  public IParticleCollectionRendererFloatInput TextureBlend { get; }
  
  public ITextureControls_t TextureControls { get; }
}