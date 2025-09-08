using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_Inflow_EntOutputHandler : IPulseCell_Inflow_BaseEntrypoint {

  public ISchemaUntypedField SourceEntity { get; }
  
  public ISchemaUntypedField SourceOutput { get; }
  
  public ISchemaUntypedField ExpectedParamType { get; }
  
}