using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseRuntimeMethodArg : ISchemaClass {

  public ISchemaUntypedField Name { get; }
  
  public ref CUtlString Description { get; }
  
  public ISchemaUntypedField Type { get; }
  
}