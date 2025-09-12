using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBaseDMStart : IPointEntity {

  
  public ISchemaUntypedField Master { get; }
}