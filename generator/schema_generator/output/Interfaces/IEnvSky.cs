using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEnvSky : IBaseModelEntity {

  public CStrongHandle<IInfoForResourceTypeIMaterial2> SkyMaterial { get; }
  
  public CStrongHandle<IInfoForResourceTypeIMaterial2> SkyMaterialLightingOnly { get; }
  
  public ref bool StartDisabled { get; }
  
  public ref Color TintColor { get; }
  
  public ref Color TintColorLightingOnly { get; }
  
  public ref float BrightnessScale { get; }
  
  public ref int FogType { get; }
  
  public ref float FogMinStart { get; }
  
  public ref float FogMinEnd { get; }
  
  public ref float FogMaxStart { get; }
  
  public ref float FogMaxEnd { get; }
  
  public ref bool Enabled { get; }
  
}