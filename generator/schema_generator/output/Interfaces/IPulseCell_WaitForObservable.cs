using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_WaitForObservable : IPulseCell_BaseYieldingInflow {

  
  public IPulseObservableBoolExpression_t Condition { get; }
  
  public IPulse_ResumePoint OnTrue { get; }
}