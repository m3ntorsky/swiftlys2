using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IModelConfigElement_Command : IModelConfigElement {

  
  public ref CUtlString Command { get; }
  
  public ISchemaUntypedField Args { get; }
}