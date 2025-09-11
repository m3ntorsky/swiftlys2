using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEmptyTestScript : IAnimScriptBase {

  
  public ISchemaUntypedField Test { get; }
}