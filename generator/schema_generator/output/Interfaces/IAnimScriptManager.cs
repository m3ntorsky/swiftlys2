using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimScriptManager : ISchemaClass {

  public ref CUtlVector ScriptInfo { get; }
  
}