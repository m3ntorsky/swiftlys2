using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RenderModels : IParticleFunctionRenderer {

  public ref bool OnlyRenderInEffectsBloomPass { get; }
  
  public ref bool OnlyRenderInEffectsWaterPass { get; }
  
  public ref bool UseMixedResolutionRendering { get; }
  
  public ref bool OnlyRenderInEffecsGameOverlay { get; }
  
  public ref CUtlVector ModelList { get; }
  
  public IParticleAttributeIndex_t BodyGroupField { get; }
  
  public IParticleAttributeIndex_t SubModelField { get; }
  
  public ref bool IgnoreNormal { get; }
  
  public ref bool OrientZ { get; }
  
  public ref bool CenterOffset { get; }
  
  public IPerParticleVecInput LocalOffset { get; }
  
  public IPerParticleVecInput LocalRotation { get; }
  
  public ref bool IgnoreRadius { get; }
  
  public ref int ModelScaleCP { get; }
  
  public IPerParticleVecInput ComponentScale { get; }
  
  public ref bool LocalScale { get; }
  
  public ref int SizeCullBloat { get; }
  
  public ref bool Animated { get; }
  
  public IPerParticleFloatInput AnimationRate { get; }
  
  public ref bool ScaleAnimationRate { get; }
  
  public ref bool ForceLoopingAnimation { get; }
  
  public ref bool ResetAnimOnStop { get; }
  
  public ref bool ManualAnimFrame { get; }
  
  public IParticleAttributeIndex_t AnimationScaleField { get; }
  
  public IParticleAttributeIndex_t AnimationField { get; }
  
  public IParticleAttributeIndex_t ManualFrameField { get; }
  
  public ISchemaFixedString ActivityName { get; }
  
  public ISchemaFixedString SequenceName { get; }
  
  public ref bool EnableClothSimulation { get; }
  
  public ISchemaFixedString ClothEffectName { get; }
  
  public ref CStrongHandle<InfoForResourceTypeIMaterial2> OverrideMaterial { get; }
  
  public ref bool OverrideTranslucentMaterials { get; }
  
  public IPerParticleFloatInput Skin { get; }
  
  public ref CUtlVector MaterialVars { get; }
  
  public IPerParticleFloatInput RenderFilter { get; }
  
  public IPerParticleFloatInput ManualModelSelection { get; }
  
  public IParticleModelInput ModelInput { get; }
  
  public ref int LOD { get; }
  
  public ISchemaFixedString EconSlotName { get; }
  
  public ref bool OriginalModel { get; }
  
  public ref bool SuppressTint { get; }
  
  public ref RenderModelSubModelFieldType_t SubModelFieldType { get; }
  
  public ref bool DisableShadows { get; }
  
  public ref bool DisableDepthPrepass { get; }
  
  public ref bool AcceptsDecals { get; }
  
  public ref bool ForceDrawInterlevedWithSiblings { get; }
  
  public ref bool DoNotDrawInParticlePass { get; }
  
  public ref bool AllowApproximateTransforms { get; }
  
  public ISchemaFixedString RenderAttribute { get; }
  
  public IParticleCollectionFloatInput RadiusScale { get; }
  
  public IParticleCollectionFloatInput AlphaScale { get; }
  
  public IParticleCollectionFloatInput RollScale { get; }
  
  public IParticleAttributeIndex_t Alpha2Field { get; }
  
  public IParticleCollectionVecInput ColorScale { get; }
  
  public ref ParticleColorBlendType_t ColorBlendType { get; }
  
}