using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulse_Constant : ISchemaClass {

  public ISchemaUntypedField Type { get; }
  
  public ISchemaUntypedField Value { get; }
  
}