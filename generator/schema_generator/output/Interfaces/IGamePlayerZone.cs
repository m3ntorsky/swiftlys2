using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IGamePlayerZone : IRuleBrushEntity {

  public IEntityIOOutput OnPlayerInZone { get; }
  
  public IEntityIOOutput OnPlayerOutZone { get; }
  
  public ISchemaUntypedField PlayersInCount { get; }
  
  public ISchemaUntypedField PlayersOutCount { get; }
  
}