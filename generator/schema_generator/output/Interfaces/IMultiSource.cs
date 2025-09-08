using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMultiSource : ILogicalEntity {

  public CHandle<IBaseEntity> RgEntities { get; }
  
  public ISchemaFixedArray<int> RgTriggered { get; }
  
  public IEntityIOOutput OnTrigger { get; }
  
  public ref int Total { get; }
  
  public ref CUtlSymbolLarge Globalstate { get; }
  
}