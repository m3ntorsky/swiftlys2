using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseNodeDynamicOutflows_t : ISchemaClass {

  
// CUtlVector< PulseNodeDynamicOutflows_t::DynamicOutflow_t >
  public ref CUtlVector Outflows { get; }
}