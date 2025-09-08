using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RenderStatusEffectCitadel : IParticleFunctionRenderer {

  public ref CStrongHandle<InfoForResourceTypeCTextureBase> TextureColorWarp { get; }
  
  public ref CStrongHandle<InfoForResourceTypeCTextureBase> TextureNormal { get; }
  
  public ref CStrongHandle<InfoForResourceTypeCTextureBase> TextureMetalness { get; }
  
  public ref CStrongHandle<InfoForResourceTypeCTextureBase> TextureRoughness { get; }
  
  public ref CStrongHandle<InfoForResourceTypeCTextureBase> TextureSelfIllum { get; }
  
  public ref CStrongHandle<InfoForResourceTypeCTextureBase> TextureDetail { get; }
  
}