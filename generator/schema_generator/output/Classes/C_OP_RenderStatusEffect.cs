using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RenderStatusEffect : CParticleFunctionRenderer, IC_OP_RenderStatusEffect {

  public C_OP_RenderStatusEffect(nint handle) : base(handle) {
  }

  public CStrongHandle<IInfoForResourceTypeCTextureBase> TextureColorWarp {
    get => new CStrongHandle<InfoForResourceTypeCTextureBase>(_Handle + Schema.GetOffset(0x2D120E02C99DEE43));
  }
  public CStrongHandle<IInfoForResourceTypeCTextureBase> TextureDetail2 {
    get => new CStrongHandle<InfoForResourceTypeCTextureBase>(_Handle + Schema.GetOffset(0x2D120E021AC8A787));
  }
  public CStrongHandle<IInfoForResourceTypeCTextureBase> TextureDiffuseWarp {
    get => new CStrongHandle<InfoForResourceTypeCTextureBase>(_Handle + Schema.GetOffset(0x2D120E02F91AF7A2));
  }
  public CStrongHandle<IInfoForResourceTypeCTextureBase> TextureFresnelColorWarp {
    get => new CStrongHandle<InfoForResourceTypeCTextureBase>(_Handle + Schema.GetOffset(0x2D120E02C8B05C0A));
  }
  public CStrongHandle<IInfoForResourceTypeCTextureBase> TextureFresnelWarp {
    get => new CStrongHandle<InfoForResourceTypeCTextureBase>(_Handle + Schema.GetOffset(0x2D120E020BCD7353));
  }
  public CStrongHandle<IInfoForResourceTypeCTextureBase> TextureSpecularWarp {
    get => new CStrongHandle<InfoForResourceTypeCTextureBase>(_Handle + Schema.GetOffset(0x2D120E02B904CD45));
  }
  public CStrongHandle<IInfoForResourceTypeCTextureBase> TextureEnvMap {
    get => new CStrongHandle<InfoForResourceTypeCTextureBase>(_Handle + Schema.GetOffset(0x2D120E0280FDA7DD));
  }


}