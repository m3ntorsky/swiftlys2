using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RenderStatusEffect : IParticleFunctionRenderer {

  public CStrongHandle<IInfoForResourceTypeCTextureBase> TextureColorWarp { get; }
  
  public CStrongHandle<IInfoForResourceTypeCTextureBase> TextureDetail2 { get; }
  
  public CStrongHandle<IInfoForResourceTypeCTextureBase> TextureDiffuseWarp { get; }
  
  public CStrongHandle<IInfoForResourceTypeCTextureBase> TextureFresnelColorWarp { get; }
  
  public CStrongHandle<IInfoForResourceTypeCTextureBase> TextureFresnelWarp { get; }
  
  public CStrongHandle<IInfoForResourceTypeCTextureBase> TextureSpecularWarp { get; }
  
  public CStrongHandle<IInfoForResourceTypeCTextureBase> TextureEnvMap { get; }
  
}