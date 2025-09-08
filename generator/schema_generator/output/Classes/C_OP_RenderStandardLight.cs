using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RenderStandardLight : CParticleFunctionRenderer, IC_OP_RenderStandardLight {

  public C_OP_RenderStandardLight(nint handle) : base(handle) {
  }

  public ref ParticleLightTypeChoiceList_t LightType {
    get => ref _Handle.AsRef<ParticleLightTypeChoiceList_t>(Schema.GetOffset(0x40395A8418C7B4A3));
  }
  public IParticleCollectionVecInput ColorScale {
    get => new CParticleCollectionVecInput(_Handle + Schema.GetOffset(0x40395A849F9BB8BA));
  }
  public ref ParticleColorBlendType_t ColorBlendType {
    get => ref _Handle.AsRef<ParticleColorBlendType_t>(Schema.GetOffset(0x40395A84DBC6EFCF));
  }
  public IParticleCollectionFloatInput Intensity {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x40395A8467B5578C));
  }
  public ref bool CastShadows {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x40395A8436113167));
  }
  public IParticleCollectionFloatInput Theta {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x40395A84F8B2ACC1));
  }
  public IParticleCollectionFloatInput Phi {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x40395A84957450E2));
  }
  public IParticleCollectionFloatInput RadiusMultiplier {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x40395A849DF78C5E));
  }
  public ref StandardLightingAttenuationStyle_t AttenuationStyle {
    get => ref _Handle.AsRef<StandardLightingAttenuationStyle_t>(Schema.GetOffset(0x40395A84AB09C83C));
  }
  public IParticleCollectionFloatInput FalloffLinearity {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x40395A84CD7C8366));
  }
  public IParticleCollectionFloatInput FiftyPercentFalloff {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x40395A84C955CBBA));
  }
  public IParticleCollectionFloatInput ZeroPercentFalloff {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x40395A8407053988));
  }
  public ref bool RenderDiffuse {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x40395A84DEDF2F65));
  }
  public ref bool RenderSpecular {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x40395A84AF965178));
  }
  public ref CUtlString LightCookie {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x40395A84E1B0CA41));
  }
  public ref int Priority {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x40395A84E7EFB335));
  }
  public ref ParticleLightFogLightingMode_t FogLightingMode {
    get => ref _Handle.AsRef<ParticleLightFogLightingMode_t>(Schema.GetOffset(0x40395A8468C76B34));
  }
  public IParticleCollectionRendererFloatInput FogContribution {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0x40395A841B30F043));
  }
  public ref ParticleLightBehaviorChoiceList_t CapsuleLightBehavior {
    get => ref _Handle.AsRef<ParticleLightBehaviorChoiceList_t>(Schema.GetOffset(0x40395A8454DF782E));
  }
  public ref float CapsuleLength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x40395A84F692B376));
  }
  public ref bool ReverseOrder {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x40395A8412C75F97));
  }
  public ref bool ClosedLoop {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x40395A847C20D1AB));
  }
  public IParticleAttributeIndex_t PrevPntSource {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x40395A84E1E5B3D3));
  }
  public ref float MaxLength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x40395A8487A8B4C7));
  }
  public ref float MinLength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x40395A8495FB8E51));
  }
  public ref bool IgnoreDT {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x40395A84530C3863));
  }
  public ref float ConstrainRadiusToLengthRatio {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x40395A8492B0E52E));
  }
  public ref float LengthScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x40395A84E312BAFF));
  }
  public ref float LengthFadeInTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x40395A84F2585C63));
  }


}