using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimScriptBase : ISchemaClass {

  
  public ref bool IsValid { get; }
}