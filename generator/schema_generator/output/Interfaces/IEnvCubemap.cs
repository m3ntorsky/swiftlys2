using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEnvCubemap : IBaseEntity {

  public CStrongHandle<IInfoForResourceTypeCTextureBase> Entity_hCubemapTexture { get; }
  
  public ref bool Entity_bCustomCubemapTexture { get; }
  
  public ref float Entity_flInfluenceRadius { get; }
  
  public ref Vector Entity_vBoxProjectMins { get; }
  
  public ref Vector Entity_vBoxProjectMaxs { get; }
  
  public ref bool Entity_bMoveable { get; }
  
  public ref int Entity_nHandshake { get; }
  
  public ref int Entity_nEnvCubeMapArrayIndex { get; }
  
  public ref int Entity_nPriority { get; }
  
  public ref float Entity_flEdgeFadeDist { get; }
  
  public ref Vector Entity_vEdgeFadeDists { get; }
  
  public ref float Entity_flDiffuseScale { get; }
  
  public ref bool Entity_bStartDisabled { get; }
  
  public ref bool Entity_bDefaultEnvMap { get; }
  
  public ref bool Entity_bDefaultSpecEnvMap { get; }
  
  public ref bool Entity_bIndoorCubeMap { get; }
  
  public ref bool Entity_bCopyDiffuseFromDefaultCubemap { get; }
  
  public ref bool Entity_bEnabled { get; }
  
}