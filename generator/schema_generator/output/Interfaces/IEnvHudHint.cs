using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEnvHudHint : IPointEntity {

  
  public ISchemaUntypedField Message { get; }
}