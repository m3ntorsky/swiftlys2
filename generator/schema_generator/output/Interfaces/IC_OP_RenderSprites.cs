using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RenderSprites : IBaseRendererSource2 {

  public IParticleCollectionRendererFloatInput SequenceOverride { get; }
  
  public ref bool SequenceNumbersAreRawSequenceIndices { get; }
  
  public ref ParticleOrientationChoiceList_t OrientationType { get; }
  
  public ref int OrientationControlPoint { get; }
  
  public ref bool UseYawWithNormalAligned { get; }
  
  public IParticleCollectionRendererFloatInput MinSize { get; }
  
  public IParticleCollectionRendererFloatInput MaxSize { get; }
  
  public IParticleCollectionRendererFloatInput AlphaAdjustWithSizeAdjust { get; }
  
  public IParticleCollectionRendererFloatInput StartFadeSize { get; }
  
  public IParticleCollectionRendererFloatInput EndFadeSize { get; }
  
  public ref float StartFadeDot { get; }
  
  public ref float EndFadeDot { get; }
  
  public ref bool DistanceAlpha { get; }
  
  public ref bool SoftEdges { get; }
  
  public ref float EdgeSoftnessStart { get; }
  
  public ref float EdgeSoftnessEnd { get; }
  
  public ref bool Outline { get; }
  
  public ref Color OutlineColor { get; }
  
  public ref int OutlineAlpha { get; }
  
  public ref float OutlineStart0 { get; }
  
  public ref float OutlineStart1 { get; }
  
  public ref float OutlineEnd0 { get; }
  
  public ref float OutlineEnd1 { get; }
  
  public ref ParticleLightingQuality_t LightingMode { get; }
  
  public IParticleCollectionRendererFloatInput LightingTessellation { get; }
  
  public IParticleCollectionRendererFloatInput LightingDirectionality { get; }
  
  public ref bool ParticleShadows { get; }
  
  public ref float ShadowDensity { get; }
  
  public IReplicationParameters ReplicationParameters { get; }
  
}