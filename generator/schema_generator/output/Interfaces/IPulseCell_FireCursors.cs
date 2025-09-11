using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_FireCursors : IPulseCell_BaseYieldingInflow {

  
// CUtlVector< CPulse_OutflowConnection >
  public ref CUtlVector Outflows { get; }
  
  public ref bool WaitForChildOutflows { get; }
  
  public IPulse_ResumePoint OnFinished { get; }
  
  public IPulse_ResumePoint OnCanceled { get; }
}