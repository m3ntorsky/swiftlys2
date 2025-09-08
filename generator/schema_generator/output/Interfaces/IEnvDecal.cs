using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEnvDecal : IBaseModelEntity {

  public CStrongHandle<IInfoForResourceTypeIMaterial2> DecalMaterial { get; }
  
  public ref float Width { get; }
  
  public ref float Height { get; }
  
  public ref float Depth { get; }
  
  public ref uint RenderOrder { get; }
  
  public ref bool ProjectOnWorld { get; }
  
  public ref bool ProjectOnCharacters { get; }
  
  public ref bool ProjectOnWater { get; }
  
  public ref float DepthSortBias { get; }
  
}