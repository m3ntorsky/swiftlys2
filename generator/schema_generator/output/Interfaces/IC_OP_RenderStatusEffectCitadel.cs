using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RenderStatusEffectCitadel : IParticleFunctionRenderer {

  public CStrongHandle<IInfoForResourceTypeCTextureBase> TextureColorWarp { get; }
  
  public CStrongHandle<IInfoForResourceTypeCTextureBase> TextureNormal { get; }
  
  public CStrongHandle<IInfoForResourceTypeCTextureBase> TextureMetalness { get; }
  
  public CStrongHandle<IInfoForResourceTypeCTextureBase> TextureRoughness { get; }
  
  public CStrongHandle<IInfoForResourceTypeCTextureBase> TextureSelfIllum { get; }
  
  public CStrongHandle<IInfoForResourceTypeCTextureBase> TextureDetail { get; }
  
}