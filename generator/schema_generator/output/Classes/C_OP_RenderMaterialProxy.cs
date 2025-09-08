using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RenderMaterialProxy : CParticleFunctionRenderer, IC_OP_RenderMaterialProxy {

  public C_OP_RenderMaterialProxy(nint handle) : base(handle) {
  }

  public ref int MaterialControlPoint {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xA7258058EACD475D));
  }
  public ref MaterialProxyType_t ProxyType {
    get => ref _Handle.AsRef<MaterialProxyType_t>(Schema.GetOffset(0xA7258058066A337F));
  }
  public ref CUtlVector MaterialVars {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xA7258058FA861D66));
  }
  public ref CStrongHandle<InfoForResourceTypeIMaterial2> OverrideMaterial {
    get => ref _Handle.AsRef<CStrongHandle<InfoForResourceTypeIMaterial2>>(Schema.GetOffset(0xA72580582C055CBE));
  }
  public IParticleCollectionFloatInput MaterialOverrideEnabled {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xA725805832275723));
  }
  public IParticleCollectionVecInput ColorScale {
    get => new CParticleCollectionVecInput(_Handle + Schema.GetOffset(0xA72580589F9BB8BA));
  }
  public IPerParticleFloatInput Alpha {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xA7258058A0DB7DD1));
  }
  public ref ParticleColorBlendType_t ColorBlendType {
    get => ref _Handle.AsRef<ParticleColorBlendType_t>(Schema.GetOffset(0xA7258058DBC6EFCF));
  }


}