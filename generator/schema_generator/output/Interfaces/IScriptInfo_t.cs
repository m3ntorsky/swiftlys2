using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IScriptInfo_t : ISchemaClass {

  
  public ref CUtlString Code { get; }
  
// CUtlVector< CAnimParamHandle >
  public ref CUtlVector ParamsModified { get; }
  
  public ref CUtlVector<int> ProxyReadParams { get; }
  
  public ref CUtlVector<int> ProxyWriteParams { get; }
  
  public ref AnimScriptType ScriptType { get; }
}