using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RenderStandardLight : IParticleFunctionRenderer {

  public ref ParticleLightTypeChoiceList_t LightType { get; }
  
  public IParticleCollectionVecInput ColorScale { get; }
  
  public ref ParticleColorBlendType_t ColorBlendType { get; }
  
  public IParticleCollectionFloatInput Intensity { get; }
  
  public ref bool CastShadows { get; }
  
  public IParticleCollectionFloatInput Theta { get; }
  
  public IParticleCollectionFloatInput Phi { get; }
  
  public IParticleCollectionFloatInput RadiusMultiplier { get; }
  
  public ref StandardLightingAttenuationStyle_t AttenuationStyle { get; }
  
  public IParticleCollectionFloatInput FalloffLinearity { get; }
  
  public IParticleCollectionFloatInput FiftyPercentFalloff { get; }
  
  public IParticleCollectionFloatInput ZeroPercentFalloff { get; }
  
  public ref bool RenderDiffuse { get; }
  
  public ref bool RenderSpecular { get; }
  
  public ref CUtlString LightCookie { get; }
  
  public ref int Priority { get; }
  
  public ref ParticleLightFogLightingMode_t FogLightingMode { get; }
  
  public IParticleCollectionRendererFloatInput FogContribution { get; }
  
  public ref ParticleLightBehaviorChoiceList_t CapsuleLightBehavior { get; }
  
  public ref float CapsuleLength { get; }
  
  public ref bool ReverseOrder { get; }
  
  public ref bool ClosedLoop { get; }
  
  public IParticleAttributeIndex_t PrevPntSource { get; }
  
  public ref float MaxLength { get; }
  
  public ref float MinLength { get; }
  
  public ref bool IgnoreDT { get; }
  
  public ref float ConstrainRadiusToLengthRatio { get; }
  
  public ref float LengthScale { get; }
  
  public ref float LengthFadeInTime { get; }
  
}