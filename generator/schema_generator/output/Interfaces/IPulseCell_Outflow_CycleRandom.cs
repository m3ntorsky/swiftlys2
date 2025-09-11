using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_Outflow_CycleRandom : IPulseCell_BaseFlow {

  
// CUtlVector< CPulse_OutflowConnection >
  public ref CUtlVector Outputs { get; }
}