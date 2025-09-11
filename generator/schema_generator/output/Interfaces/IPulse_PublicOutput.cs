using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulse_PublicOutput : ISchemaClass {

  
  public ISchemaUntypedField Name { get; }
  
  public ref CUtlString Description { get; }
  
  public ref CUtlLeanVector<CPulseRuntimeMethodArg> Args { get; }
}