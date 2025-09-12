using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBaseRendererSource2 : CParticleFunctionRenderer, IBaseRendererSource2 {

  public CBaseRendererSource2(nint handle) : base(handle) {
  }

  public IParticleCollectionRendererFloatInput RadiusScale {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0xA732A575A7A20159));
  }
  public IParticleCollectionRendererFloatInput AlphaScale {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0xA732A575EC6D3C25));
  }
  public IParticleCollectionRendererFloatInput RollScale {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0xA732A575F2113F72));
  }
  public IParticleAttributeIndex_t Alpha2Field {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xA732A575F60EADC1));
  }
  public IParticleCollectionRendererVecInput ColorScale {
    get => new CParticleCollectionRendererVecInput(_Handle + Schema.GetOffset(0xA732A5759F9BB8BA));
  }
  public ref ParticleColorBlendType_t ColorBlendType {
    get => ref _Handle.AsRef<ParticleColorBlendType_t>(Schema.GetOffset(0xA732A575DBC6EFCF));
  }
  public ref SpriteCardShaderType_t ShaderType {
    get => ref _Handle.AsRef<SpriteCardShaderType_t>(Schema.GetOffset(0xA732A57512186AAC));
  }
  public ref CUtlString StrShaderOverride {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xA732A575DB9D2E61));
  }
  public IParticleCollectionRendererFloatInput CenterXOffset {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0xA732A5755E388DB9));
  }
  public IParticleCollectionRendererFloatInput CenterYOffset {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0xA732A575174B557E));
  }
  public ref float BumpStrength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA732A575CF5943B6));
  }
  public ref ParticleSequenceCropOverride_t CropTextureOverride {
    get => ref _Handle.AsRef<ParticleSequenceCropOverride_t>(Schema.GetOffset(0xA732A575F1DF7F72));
  }
  public ISchemaUntypedField TexturesInput {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xA732A5759C246F7B));
  }
  public ref float AnimationRate {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA732A575607083AD));
  }
  public ref AnimationType_t AnimationType {
    get => ref _Handle.AsRef<AnimationType_t>(Schema.GetOffset(0xA732A575B93FDFD1));
  }
  public ref bool AnimateInFPS {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA732A5757C271B16));
  }
  public IParticleCollectionRendererFloatInput MotionVectorScaleU {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0xA732A575C6578D67));
  }
  public IParticleCollectionRendererFloatInput MotionVectorScaleV {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0xA732A575C7578EFA));
  }
  public IParticleCollectionRendererFloatInput SelfIllumAmount {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0xA732A57567914AEA));
  }
  public IParticleCollectionRendererFloatInput DiffuseAmount {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0xA732A5755D3E7ADB));
  }
  public IParticleCollectionRendererFloatInput DiffuseClamp {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0xA732A57505150956));
  }
  public ref int LightingControlPoint {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xA732A57575FC81F8));
  }
  public IParticleAttributeIndex_t SelfIllumPerParticle {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xA732A57513479BAD));
  }
  public ref ParticleOutputBlendMode_t OutputBlendMode {
    get => ref _Handle.AsRef<ParticleOutputBlendMode_t>(Schema.GetOffset(0xA732A575D966012C));
  }
  public ref bool GammaCorrectVertexColors {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA732A575D7525C4E));
  }
  public ref bool SaturateColorPreAlphaBlend {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA732A57566D1A423));
  }
  public IParticleCollectionRendererFloatInput AddSelfAmount {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0xA732A575320867E0));
  }
  public IParticleCollectionRendererFloatInput Desaturation {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0xA732A575E9D4602C));
  }
  public IParticleCollectionRendererFloatInput OverbrightFactor {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0xA732A5755D81C136));
  }
  public ref int HSVShiftControlPoint {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xA732A5758848C01F));
  }
  public ref ParticleFogType_t FogType {
    get => ref _Handle.AsRef<ParticleFogType_t>(Schema.GetOffset(0xA732A575381735D3));
  }
  public IParticleCollectionRendererFloatInput FogAmount {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0xA732A5755F653F7D));
  }
  public ref bool TintByFOW {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA732A575B0996EB3));
  }
  public ref bool TintByGlobalLight {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA732A5750CE8D4E6));
  }
  public ref SpriteCardPerParticleScale_t PerParticleAlphaReference {
    get => ref _Handle.AsRef<SpriteCardPerParticleScale_t>(Schema.GetOffset(0xA732A57583A25BA7));
  }
  public ref SpriteCardPerParticleScale_t PerParticleAlphaRefWindow {
    get => ref _Handle.AsRef<SpriteCardPerParticleScale_t>(Schema.GetOffset(0xA732A57504EE3223));
  }
  public ref ParticleAlphaReferenceType_t AlphaReferenceType {
    get => ref _Handle.AsRef<ParticleAlphaReferenceType_t>(Schema.GetOffset(0xA732A57534D288AC));
  }
  public IParticleCollectionRendererFloatInput AlphaReferenceSoftness {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0xA732A57511F07241));
  }
  public IParticleCollectionRendererFloatInput SourceAlphaValueToMapToZero {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0xA732A575831C1E67));
  }
  public IParticleCollectionRendererFloatInput SourceAlphaValueToMapToOne {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0xA732A575B40EE1B3));
  }
  public ref bool Refract {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA732A57589DE613C));
  }
  public ref bool RefractSolid {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA732A575136EF0D3));
  }
  public IParticleCollectionRendererFloatInput RefractAmount {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0xA732A575A649E3EE));
  }
  public ref int RefractBlurRadius {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xA732A5750666EA9F));
  }
  public ref BlurFilterType_t RefractBlurType {
    get => ref _Handle.AsRef<BlurFilterType_t>(Schema.GetOffset(0xA732A575BD296B09));
  }
  public ref bool OnlyRenderInEffectsBloomPass {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA732A575D6FA0FBC));
  }
  public ref bool OnlyRenderInEffectsWaterPass {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA732A575111BB03C));
  }
  public ref bool UseMixedResolutionRendering {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA732A5758C2B17B7));
  }
  public ref bool OnlyRenderInEffecsGameOverlay {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA732A5750293C80E));
  }
  public ISchemaFixedString StencilTestID {
    get => new SchemaFixedString(_Handle, 0xA732A575115C996A, 128, 1, 1);
  }
  public ref bool StencilTestExclude {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA732A57584BFB66B));
  }
  public ISchemaFixedString StencilWriteID {
    get => new SchemaFixedString(_Handle, 0xA732A5758FB6505B, 128, 1, 1);
  }
  public ref bool WriteStencilOnDepthPass {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA732A575016CB7AF));
  }
  public ref bool WriteStencilOnDepthFail {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA732A575AEF0A1FE));
  }
  public ref bool ReverseZBuffering {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA732A575256F9FB5));
  }
  public ref bool DisableZBuffering {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA732A5754AA2BB4F));
  }
  public ref ParticleDepthFeatheringMode_t FeatheringMode {
    get => ref _Handle.AsRef<ParticleDepthFeatheringMode_t>(Schema.GetOffset(0xA732A5759C2E72DF));
  }
  public IParticleCollectionRendererFloatInput FeatheringMinDist {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0xA732A575914C2A42));
  }
  public IParticleCollectionRendererFloatInput FeatheringMaxDist {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0xA732A575DB46DE3C));
  }
  public IParticleCollectionRendererFloatInput FeatheringFilter {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0xA732A575E4FA3CA4));
  }
  public IParticleCollectionRendererFloatInput FeatheringDepthMapFilter {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0xA732A575D0940CBD));
  }
  public IParticleCollectionRendererFloatInput DepthBias {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0xA732A5752E72BBFD));
  }
  public ref ParticleSortingChoiceList_t SortMethod {
    get => ref _Handle.AsRef<ParticleSortingChoiceList_t>(Schema.GetOffset(0xA732A5759540F498));
  }
  public ref bool BlendFramesSeq0 {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA732A57505041FEB));
  }
  public ref bool MaxLuminanceBlendingSequence0 {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA732A5751E409BEF));
  }


}