using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_TestWaitWithCursorState : IPulseCell_BaseYieldingInflow {

  
  public IPulse_ResumePoint WakeResume { get; }
  
  public IPulse_ResumePoint WakeCancel { get; }
  
  public IPulse_ResumePoint WakeFail { get; }
}