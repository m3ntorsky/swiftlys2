using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_Outflow_TestRandomYesNo : IPulseCell_BaseFlow {

  
  public IPulse_OutflowConnection Yes { get; }
  
  public IPulse_OutflowConnection No { get; }
}