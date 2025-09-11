using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_Timeline : IPulseCell_BaseYieldingInflow {

  
// CUtlVector< CPulseCell_Timeline::TimelineEvent_t >
  public ref CUtlVector TimelineEvents { get; }
  
  public ref bool WaitForChildOutflows { get; }
  
  public IPulse_ResumePoint OnFinished { get; }
  
  public IPulse_ResumePoint OnCanceled { get; }
}