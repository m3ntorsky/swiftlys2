using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFilterEnemy : IBaseFilter {

  
  public ISchemaUntypedField EnemyName { get; }
  
  public ref float Radius { get; }
  
  public ref float OuterRadius { get; }
  
  public ref int MaxSquadmatesPerEnemy { get; }
  
  public ISchemaUntypedField PlayerName { get; }
}