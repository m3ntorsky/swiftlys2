using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IResponseContext_t : ISchemaClass {

  
  public ISchemaUntypedField Name { get; }
  
  public ISchemaUntypedField Value { get; }
  
  public IGameTime_t ExpirationTime { get; }
}