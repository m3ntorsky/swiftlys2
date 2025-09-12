using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEnvGlobal : ILogicalEntity {

  
  public ISchemaUntypedField OutCounter { get; }
  
  public ISchemaUntypedField Globalstate { get; }
  
  public ref int Triggermode { get; }
  
  public ref int Initialstate { get; }
  
  public ref int Counter { get; }
}