using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFilterMultiple : IBaseFilter {

  public ref filter_t FilterType { get; }
  
  public ISchemaFixedArray<CUtlSymbolLarge> FilterName { get; }
  
  public CHandle<IBaseEntity> Filter { get; }
  
}