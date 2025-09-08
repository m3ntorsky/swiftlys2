using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RenderStatusEffect : IParticleFunctionRenderer {

  public ref CStrongHandle<InfoForResourceTypeCTextureBase> TextureColorWarp { get; }
  
  public ref CStrongHandle<InfoForResourceTypeCTextureBase> TextureDetail2 { get; }
  
  public ref CStrongHandle<InfoForResourceTypeCTextureBase> TextureDiffuseWarp { get; }
  
  public ref CStrongHandle<InfoForResourceTypeCTextureBase> TextureFresnelColorWarp { get; }
  
  public ref CStrongHandle<InfoForResourceTypeCTextureBase> TextureFresnelWarp { get; }
  
  public ref CStrongHandle<InfoForResourceTypeCTextureBase> TextureSpecularWarp { get; }
  
  public ref CStrongHandle<InfoForResourceTypeCTextureBase> TextureEnvMap { get; }
  
}