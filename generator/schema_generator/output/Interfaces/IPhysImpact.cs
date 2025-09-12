using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPhysImpact : IPointEntity {

  
  public ref float Damage { get; }
  
  public ref float Distance { get; }
  
  public ISchemaUntypedField DirectionEntityName { get; }
}