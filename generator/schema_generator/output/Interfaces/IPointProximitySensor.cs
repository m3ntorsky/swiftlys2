using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPointProximitySensor : IPointEntity {

  public ref bool Disabled { get; }
  
  public CHandle<IBaseEntity> TargetEntity { get; }
  
  public ISchemaUntypedField Distance { get; }
  
}