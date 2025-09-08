using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RenderOmni2Light : CParticleFunctionRenderer, IC_OP_RenderOmni2Light {

  public C_OP_RenderOmni2Light(nint handle) : base(handle) {
  }

  public ref ParticleOmni2LightTypeChoiceList_t LightType {
    get => ref _Handle.AsRef<ParticleOmni2LightTypeChoiceList_t>(Schema.GetOffset(0xDE9AF4EE18C7B4A3));
  }
  public IParticleCollectionVecInput ColorBlend {
    get => new CParticleCollectionVecInput(_Handle + Schema.GetOffset(0xDE9AF4EE740E9A5F));
  }
  public ref ParticleColorBlendType_t ColorBlendType {
    get => ref _Handle.AsRef<ParticleColorBlendType_t>(Schema.GetOffset(0xDE9AF4EEDBC6EFCF));
  }
  public ref ParticleLightUnitChoiceList_t BrightnessUnit {
    get => ref _Handle.AsRef<ParticleLightUnitChoiceList_t>(Schema.GetOffset(0xDE9AF4EE2A6E4030));
  }
  public IPerParticleFloatInput BrightnessLumens {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xDE9AF4EEC542F6EA));
  }
  public IPerParticleFloatInput BrightnessCandelas {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xDE9AF4EEE3A4688B));
  }
  public ref bool CastShadows {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xDE9AF4EE36113167));
  }
  public ref bool Fog {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xDE9AF4EECA77E01F));
  }
  public IPerParticleFloatInput FogScale {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xDE9AF4EECF999E05));
  }
  public IPerParticleFloatInput LuminaireRadius {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xDE9AF4EECB5A5B89));
  }
  public IPerParticleFloatInput Skirt {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xDE9AF4EEEAFB6D2A));
  }
  public IPerParticleFloatInput Range {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xDE9AF4EE3FC92844));
  }
  public IPerParticleFloatInput InnerConeAngle {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xDE9AF4EE16875B1D));
  }
  public IPerParticleFloatInput OuterConeAngle {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xDE9AF4EE90EF9464));
  }
  public CStrongHandle<IInfoForResourceTypeCTextureBase> LightCookie {
    get => new CStrongHandle<InfoForResourceTypeCTextureBase>(_Handle + Schema.GetOffset(0xDE9AF4EE0609D103));
  }
  public ref bool SphericalCookie {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xDE9AF4EE6C822B6E));
  }


}