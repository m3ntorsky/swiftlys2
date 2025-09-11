using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimScriptManager : ISchemaClass {

  
// CUtlVector< ScriptInfo_t >
  public ref CUtlVector ScriptInfo { get; }
}