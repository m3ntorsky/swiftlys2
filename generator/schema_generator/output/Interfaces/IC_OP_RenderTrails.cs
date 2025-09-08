using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RenderTrails : IBaseTrailRenderer {

  public ref bool EnableFadingAndClamping { get; }
  
  public ref float StartFadeDot { get; }
  
  public ref float EndFadeDot { get; }
  
  public IParticleAttributeIndex_t PrevPntSource { get; }
  
  public ref float MaxLength { get; }
  
  public ref float MinLength { get; }
  
  public ref bool IgnoreDT { get; }
  
  public ref float ConstrainRadiusToLengthRatio { get; }
  
  public ref float LengthScale { get; }
  
  public ref float LengthFadeInTime { get; }
  
  public IPerParticleFloatInput RadiusHeadTaper { get; }
  
  public IParticleCollectionVecInput HeadColorScale { get; }
  
  public IPerParticleFloatInput HeadAlphaScale { get; }
  
  public IPerParticleFloatInput RadiusTaper { get; }
  
  public IParticleCollectionVecInput TailColorScale { get; }
  
  public IPerParticleFloatInput TailAlphaScale { get; }
  
  public IParticleAttributeIndex_t HorizCropField { get; }
  
  public IParticleAttributeIndex_t VertCropField { get; }
  
  public ref float ForwardShift { get; }
  
  public ref bool FlipUVBasedOnPitchYaw { get; }
  
}