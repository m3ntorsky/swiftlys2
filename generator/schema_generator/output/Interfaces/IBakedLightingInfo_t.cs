using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBakedLightingInfo_t : ISchemaClass {

  
  public ref uint LightmapVersionNumber { get; }
  
  public ref uint LightmapGameVersionNumber { get; }
  
  public ref Vector2D LightmapUvScale { get; }
  
  public ref bool HasLightmaps { get; }
  
  public ref bool BakedShadowsGamma20 { get; }
  
  public ref bool CompressionEnabled { get; }
  
  public ref bool SHLightmaps { get; }
  
  public ref byte ChartPackIterations { get; }
  
  public ref byte VradQuality { get; }
  
  public ref CUtlVector<CStrongHandle<InfoForResourceTypeCTextureBase>> LightMaps { get; }
  
// CUtlVector< BakedLightingInfo_t::BakedShadowAssignment_t >
  public ref CUtlVector BakedShadows { get; }
}