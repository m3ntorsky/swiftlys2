using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPointEntityFinder : IBaseEntity {

  
  public ref CHandle<CBaseEntity> Entity { get; }
  
  public ref CUtlSymbolLarge FilterName { get; }
  
  public ref CHandle<CBaseFilter> Filter { get; }
  
  public ref CUtlSymbolLarge RefName { get; }
  
  public ref CHandle<CBaseEntity> Reference { get; }
  
  public ref EntFinderMethod_t FindMethod { get; }
  
  public IEntityIOOutput OnFoundEntity { get; }
}