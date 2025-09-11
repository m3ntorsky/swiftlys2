using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFilterEnemy : IBaseFilter {

  
  public ref CUtlSymbolLarge EnemyName { get; }
  
  public ref float Radius { get; }
  
  public ref float OuterRadius { get; }
  
  public ref int MaxSquadmatesPerEnemy { get; }
  
  public ref CUtlSymbolLarge PlayerName { get; }
}