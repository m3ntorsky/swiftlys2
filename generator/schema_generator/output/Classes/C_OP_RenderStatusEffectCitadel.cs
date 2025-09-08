using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RenderStatusEffectCitadel : CParticleFunctionRenderer, IC_OP_RenderStatusEffectCitadel {

  public C_OP_RenderStatusEffectCitadel(nint handle) : base(handle) {
  }

  public CStrongHandle<IInfoForResourceTypeCTextureBase> TextureColorWarp {
    get => new CStrongHandle<InfoForResourceTypeCTextureBase>(_Handle + Schema.GetOffset(0x3A3089C2C99DEE43));
  }
  public CStrongHandle<IInfoForResourceTypeCTextureBase> TextureNormal {
    get => new CStrongHandle<InfoForResourceTypeCTextureBase>(_Handle + Schema.GetOffset(0x3A3089C298E8363D));
  }
  public CStrongHandle<IInfoForResourceTypeCTextureBase> TextureMetalness {
    get => new CStrongHandle<InfoForResourceTypeCTextureBase>(_Handle + Schema.GetOffset(0x3A3089C25ABD9B42));
  }
  public CStrongHandle<IInfoForResourceTypeCTextureBase> TextureRoughness {
    get => new CStrongHandle<InfoForResourceTypeCTextureBase>(_Handle + Schema.GetOffset(0x3A3089C2BD0AD95C));
  }
  public CStrongHandle<IInfoForResourceTypeCTextureBase> TextureSelfIllum {
    get => new CStrongHandle<InfoForResourceTypeCTextureBase>(_Handle + Schema.GetOffset(0x3A3089C2D815240D));
  }
  public CStrongHandle<IInfoForResourceTypeCTextureBase> TextureDetail {
    get => new CStrongHandle<InfoForResourceTypeCTextureBase>(_Handle + Schema.GetOffset(0x3A3089C28D414A8F));
  }


}