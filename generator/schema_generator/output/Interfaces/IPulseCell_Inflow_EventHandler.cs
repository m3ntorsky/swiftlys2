using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_Inflow_EventHandler : IPulseCell_Inflow_BaseEntrypoint {

  public ISchemaUntypedField EventName { get; }
  
}