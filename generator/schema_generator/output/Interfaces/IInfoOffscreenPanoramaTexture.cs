using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IInfoOffscreenPanoramaTexture : IPointEntity {

  
  public ref bool Disabled { get; }
  
  public ref int ResolutionX { get; }
  
  public ref int ResolutionY { get; }
  
  public ISchemaUntypedField LayoutFileName { get; }
  
  public ISchemaUntypedField RenderAttrName { get; }
  
  public ref CUtlVector<CHandle<CBaseModelEntity>> TargetEntities { get; }
  
  public ref int TargetChangeCount { get; }
  
// CNetworkUtlVectorBase< CUtlSymbolLarge >
  public ref CUtlVector CSSClasses { get; }
  
  public ISchemaUntypedField TargetsName { get; }
  
  public ref CUtlVector<CHandle<CBaseModelEntity>> AdditionalTargetEntities { get; }
}