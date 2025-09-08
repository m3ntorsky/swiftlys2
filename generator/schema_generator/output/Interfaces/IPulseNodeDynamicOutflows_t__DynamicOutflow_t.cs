using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseNodeDynamicOutflows_t__DynamicOutflow_t : ISchemaClass {

  public ref CGlobalSymbol OutflowID { get; }
  
  public IPulse_OutflowConnection Connection { get; }
  
}