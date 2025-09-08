using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IInfoWorldLayer : IBaseEntity {

  public IEntityIOOutput OutputOnEntitiesSpawned { get; }
  
  public ref CUtlSymbolLarge WorldName { get; }
  
  public ref CUtlSymbolLarge LayerName { get; }
  
  public ref bool WorldLayerVisible { get; }
  
  public ref bool EntitiesSpawned { get; }
  
  public ref bool CreateAsChildSpawnGroup { get; }
  
  public ref uint LayerSpawnGroup { get; }
  
}