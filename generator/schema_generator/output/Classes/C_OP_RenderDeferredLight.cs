using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RenderDeferredLight : CParticleFunctionRenderer, IC_OP_RenderDeferredLight {

  public C_OP_RenderDeferredLight(nint handle) : base(handle) {
  }

  public ref bool UseAlphaTestWindow {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x44291266951B0D10));
  }
  public ref bool UseTexture {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x4429126624A2D28F));
  }
  public ref float RadiusScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x44291266A7A20159));
  }
  public ref float AlphaScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x44291266EC6D3C25));
  }
  public IParticleAttributeIndex_t Alpha2Field {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x44291266F60EADC1));
  }
  public IParticleCollectionVecInput ColorScale {
    get => new CParticleCollectionVecInput(_Handle + Schema.GetOffset(0x442912669F9BB8BA));
  }
  public ref ParticleColorBlendType_t ColorBlendType {
    get => ref _Handle.AsRef<ParticleColorBlendType_t>(Schema.GetOffset(0x44291266DBC6EFCF));
  }
  public ref float LightDistance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x44291266FAE1FD66));
  }
  public ref float StartFalloff {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x44291266A8F25925));
  }
  public ref float DistanceFalloff {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x44291266A9C33036));
  }
  public ref float SpotFoV {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x44291266D202E536));
  }
  public IParticleAttributeIndex_t AlphaTestPointField {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x442912666AD21C15));
  }
  public IParticleAttributeIndex_t AlphaTestRangeField {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x442912663E3E66D4));
  }
  public IParticleAttributeIndex_t AlphaTestSharpnessField {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x44291266BCB74B82));
  }
  public CStrongHandle<IInfoForResourceTypeCTextureBase> Texture {
    get => new CStrongHandle<InfoForResourceTypeCTextureBase>(_Handle + Schema.GetOffset(0x442912668C0A2FB6));
  }
  public ref int HSVShiftControlPoint {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x442912668848C01F));
  }


}