using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_Outflow_StringSwitch : IPulseCell_BaseFlow {

  
  public IPulse_OutflowConnection DefaultCaseOutflow { get; }
  
// CUtlVector< CPulse_OutflowConnection >
  public ref CUtlVector CaseOutflows { get; }
}