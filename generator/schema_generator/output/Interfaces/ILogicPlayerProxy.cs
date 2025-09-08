using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ILogicPlayerProxy : ILogicalEntity {

  public CHandle<IBaseEntity> Player { get; }
  
  public IEntityIOOutput PlayerHasAmmo { get; }
  
  public IEntityIOOutput PlayerHasNoAmmo { get; }
  
  public IEntityIOOutput PlayerDied { get; }
  
  public ISchemaUntypedField RequestedPlayerHealth { get; }
  
}