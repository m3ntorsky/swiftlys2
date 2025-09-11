using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_Inflow_GraphHook : IPulseCell_Inflow_BaseEntrypoint {

  
  public ISchemaUntypedField HookName { get; }
}