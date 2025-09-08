using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBaseTrailRenderer : IBaseRendererSource2 {

  public ref ParticleOrientationChoiceList_t OrientationType { get; }
  
  public ref int OrientationControlPoint { get; }
  
  public ref float MinSize { get; }
  
  public ref float MaxSize { get; }
  
  public IParticleCollectionRendererFloatInput StartFadeSize { get; }
  
  public IParticleCollectionRendererFloatInput EndFadeSize { get; }
  
  public ref bool ClampV { get; }
  
}