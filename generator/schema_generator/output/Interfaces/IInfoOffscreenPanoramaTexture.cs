using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IInfoOffscreenPanoramaTexture : IPointEntity {

  public ref bool Disabled { get; }
  
  public ref int ResolutionX { get; }
  
  public ref int ResolutionY { get; }
  
  public ref CUtlSymbolLarge LayoutFileName { get; }
  
  public ref CUtlSymbolLarge RenderAttrName { get; }
  
  public ref CUtlVector TargetEntities { get; }
  
  public ref int TargetChangeCount { get; }
  
  public ref CUtlVector<CUtlSymbolLarge> CSSClasses { get; }
  
  public ref CUtlSymbolLarge TargetsName { get; }
  
  public ref CUtlVector AdditionalTargetEntities { get; }
  
}