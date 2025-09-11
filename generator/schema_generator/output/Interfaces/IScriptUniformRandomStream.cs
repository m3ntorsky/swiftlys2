using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IScriptUniformRandomStream : ISchemaClass {

  
  public ISchemaUntypedField ScriptScope { get; }
  
  public ref int InitialSeed { get; }
}