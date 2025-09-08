using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMultiLightProxy : ILogicalEntity {

  public ref CUtlSymbolLarge LightNameFilter { get; }
  
  public ref CUtlSymbolLarge LightClassFilter { get; }
  
  public ref float LightRadiusFilter { get; }
  
  public ref float BrightnessDelta { get; }
  
  public ref bool PerformScreenFade { get; }
  
  public ref float TargetBrightnessMultiplier { get; }
  
  public ref float CurrentBrightnessMultiplier { get; }
  
  public ref CUtlVector<CHandle<CLightEntity>> Lights { get; }
  
}