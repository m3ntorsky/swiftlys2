using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEnvLightProbeVolume : IBaseEntity {

  public ref CStrongHandle<InfoForResourceTypeCTextureBase> Entity_hLightProbeTexture_AmbientCube { get; }
  
  public ref CStrongHandle<InfoForResourceTypeCTextureBase> Entity_hLightProbeTexture_SDF { get; }
  
  public ref CStrongHandle<InfoForResourceTypeCTextureBase> Entity_hLightProbeTexture_SH2_DC { get; }
  
  public ref CStrongHandle<InfoForResourceTypeCTextureBase> Entity_hLightProbeTexture_SH2_R { get; }
  
  public ref CStrongHandle<InfoForResourceTypeCTextureBase> Entity_hLightProbeTexture_SH2_G { get; }
  
  public ref CStrongHandle<InfoForResourceTypeCTextureBase> Entity_hLightProbeTexture_SH2_B { get; }
  
  public ref CStrongHandle<InfoForResourceTypeCTextureBase> Entity_hLightProbeDirectLightIndicesTexture { get; }
  
  public ref CStrongHandle<InfoForResourceTypeCTextureBase> Entity_hLightProbeDirectLightScalarsTexture { get; }
  
  public ref CStrongHandle<InfoForResourceTypeCTextureBase> Entity_hLightProbeDirectLightShadowsTexture { get; }
  
  public ref Vector Entity_vBoxMins { get; }
  
  public ref Vector Entity_vBoxMaxs { get; }
  
  public ref bool Entity_bMoveable { get; }
  
  public ref int Entity_nHandshake { get; }
  
  public ref int Entity_nPriority { get; }
  
  public ref bool Entity_bStartDisabled { get; }
  
  public ref int Entity_nLightProbeSizeX { get; }
  
  public ref int Entity_nLightProbeSizeY { get; }
  
  public ref int Entity_nLightProbeSizeZ { get; }
  
  public ref int Entity_nLightProbeAtlasX { get; }
  
  public ref int Entity_nLightProbeAtlasY { get; }
  
  public ref int Entity_nLightProbeAtlasZ { get; }
  
  public ref bool Entity_bEnabled { get; }
  
}