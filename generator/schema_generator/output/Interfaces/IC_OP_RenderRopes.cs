using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RenderRopes : IBaseRendererSource2 {

  public ref bool EnableFadingAndClamping { get; }
  
  public ref float MinSize { get; }
  
  public ref float MaxSize { get; }
  
  public ref float StartFadeSize { get; }
  
  public ref float EndFadeSize { get; }
  
  public ref float StartFadeDot { get; }
  
  public ref float EndFadeDot { get; }
  
  public ref float RadiusTaper { get; }
  
  public ref int MinTesselation { get; }
  
  public ref int MaxTesselation { get; }
  
  public ref float TessScale { get; }
  
  public IParticleCollectionRendererFloatInput TextureVWorldSize { get; }
  
  public IParticleCollectionRendererFloatInput TextureVScrollRate { get; }
  
  public IParticleCollectionRendererFloatInput TextureVOffset { get; }
  
  public ref int TextureVParamsCP { get; }
  
  public ref bool ClampV { get; }
  
  public ref int ScaleCP1 { get; }
  
  public ref int ScaleCP2 { get; }
  
  public ref float ScaleVSizeByControlPointDistance { get; }
  
  public ref float ScaleVScrollByControlPointDistance { get; }
  
  public ref float ScaleVOffsetByControlPointDistance { get; }
  
  public ref bool UseScalarForTextureCoordinate { get; }
  
  public IParticleAttributeIndex_t ScalarFieldForTextureCoordinate { get; }
  
  public ref float ScalarAttributeTextureCoordScale { get; }
  
  public ref bool ReverseOrder { get; }
  
  public ref bool ClosedLoop { get; }
  
  public ref ParticleOrientationChoiceList_t OrientationType { get; }
  
  public IParticleAttributeIndex_t VectorFieldForOrientation { get; }
  
  public ref bool DrawAsOpaque { get; }
  
  public ref bool GenerateNormals { get; }
  
}