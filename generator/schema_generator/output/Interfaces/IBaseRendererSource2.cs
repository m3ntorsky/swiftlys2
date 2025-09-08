using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBaseRendererSource2 : IParticleFunctionRenderer {

  public IParticleCollectionRendererFloatInput RadiusScale { get; }
  
  public IParticleCollectionRendererFloatInput AlphaScale { get; }
  
  public IParticleCollectionRendererFloatInput RollScale { get; }
  
  public IParticleAttributeIndex_t Alpha2Field { get; }
  
  public IParticleCollectionRendererVecInput ColorScale { get; }
  
  public ref ParticleColorBlendType_t ColorBlendType { get; }
  
  public ref SpriteCardShaderType_t ShaderType { get; }
  
  public ref CUtlString StrShaderOverride { get; }
  
  public IParticleCollectionRendererFloatInput CenterXOffset { get; }
  
  public IParticleCollectionRendererFloatInput CenterYOffset { get; }
  
  public ref float BumpStrength { get; }
  
  public ref ParticleSequenceCropOverride_t CropTextureOverride { get; }
  
  public ref CUtlLeanVector<TextureGroup_t> TexturesInput { get; }
  
  public ref float AnimationRate { get; }
  
  public ref AnimationType_t AnimationType { get; }
  
  public ref bool AnimateInFPS { get; }
  
  public IParticleCollectionRendererFloatInput MotionVectorScaleU { get; }
  
  public IParticleCollectionRendererFloatInput MotionVectorScaleV { get; }
  
  public IParticleCollectionRendererFloatInput SelfIllumAmount { get; }
  
  public IParticleCollectionRendererFloatInput DiffuseAmount { get; }
  
  public IParticleCollectionRendererFloatInput DiffuseClamp { get; }
  
  public ref int LightingControlPoint { get; }
  
  public IParticleAttributeIndex_t SelfIllumPerParticle { get; }
  
  public ref ParticleOutputBlendMode_t OutputBlendMode { get; }
  
  public ref bool GammaCorrectVertexColors { get; }
  
  public ref bool SaturateColorPreAlphaBlend { get; }
  
  public IParticleCollectionRendererFloatInput AddSelfAmount { get; }
  
  public IParticleCollectionRendererFloatInput Desaturation { get; }
  
  public IParticleCollectionRendererFloatInput OverbrightFactor { get; }
  
  public ref int HSVShiftControlPoint { get; }
  
  public ref ParticleFogType_t FogType { get; }
  
  public IParticleCollectionRendererFloatInput FogAmount { get; }
  
  public ref bool TintByFOW { get; }
  
  public ref bool TintByGlobalLight { get; }
  
  public ref SpriteCardPerParticleScale_t PerParticleAlphaReference { get; }
  
  public ref SpriteCardPerParticleScale_t PerParticleAlphaRefWindow { get; }
  
  public ref ParticleAlphaReferenceType_t AlphaReferenceType { get; }
  
  public IParticleCollectionRendererFloatInput AlphaReferenceSoftness { get; }
  
  public IParticleCollectionRendererFloatInput SourceAlphaValueToMapToZero { get; }
  
  public IParticleCollectionRendererFloatInput SourceAlphaValueToMapToOne { get; }
  
  public ref bool Refract { get; }
  
  public ref bool RefractSolid { get; }
  
  public IParticleCollectionRendererFloatInput RefractAmount { get; }
  
  public ref int RefractBlurRadius { get; }
  
  public ref BlurFilterType_t RefractBlurType { get; }
  
  public ref bool OnlyRenderInEffectsBloomPass { get; }
  
  public ref bool OnlyRenderInEffectsWaterPass { get; }
  
  public ref bool UseMixedResolutionRendering { get; }
  
  public ref bool OnlyRenderInEffecsGameOverlay { get; }
  
  public ISchemaFixedString StencilTestID { get; }
  
  public ref bool StencilTestExclude { get; }
  
  public ISchemaFixedString StencilWriteID { get; }
  
  public ref bool WriteStencilOnDepthPass { get; }
  
  public ref bool WriteStencilOnDepthFail { get; }
  
  public ref bool ReverseZBuffering { get; }
  
  public ref bool DisableZBuffering { get; }
  
  public ref ParticleDepthFeatheringMode_t FeatheringMode { get; }
  
  public IParticleCollectionRendererFloatInput FeatheringMinDist { get; }
  
  public IParticleCollectionRendererFloatInput FeatheringMaxDist { get; }
  
  public IParticleCollectionRendererFloatInput FeatheringFilter { get; }
  
  public IParticleCollectionRendererFloatInput FeatheringDepthMapFilter { get; }
  
  public IParticleCollectionRendererFloatInput DepthBias { get; }
  
  public ref ParticleSortingChoiceList_t SortMethod { get; }
  
  public ref bool BlendFramesSeq0 { get; }
  
  public ref bool MaxLuminanceBlendingSequence0 { get; }
  
}