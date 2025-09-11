using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulse_OutputConnection : ISchemaClass {

  
  public ISchemaUntypedField SourceOutput { get; }
  
  public ISchemaUntypedField TargetEntity { get; }
  
  public ISchemaUntypedField TargetInput { get; }
  
  public ISchemaUntypedField Param { get; }
}