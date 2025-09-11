using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimGraphModelBinding : ISchemaClass {

  
  public ref CUtlString ModelName { get; }
  
  public ISchemaUntypedField SharedData { get; }
}