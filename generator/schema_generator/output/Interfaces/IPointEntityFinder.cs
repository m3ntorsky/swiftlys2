using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPointEntityFinder : IBaseEntity {

  public CHandle<IBaseEntity> Entity { get; }
  
  public ref CUtlSymbolLarge FilterName { get; }
  
  public CHandle<IBaseFilter> Filter { get; }
  
  public ref CUtlSymbolLarge RefName { get; }
  
  public CHandle<IBaseEntity> Reference { get; }
  
  public ref EntFinderMethod_t FindMethod { get; }
  
  public IEntityIOOutput OnFoundEntity { get; }
  
}