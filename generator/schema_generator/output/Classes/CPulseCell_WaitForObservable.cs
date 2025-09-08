using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_WaitForObservable : CPulseCell_BaseYieldingInflow, IPulseCell_WaitForObservable {

  public CPulseCell_WaitForObservable(nint handle) : base(handle) {
  }

  public IPulseObservableBoolExpression_t Condition {
    get => new PulseObservableBoolExpression_t(_Handle + Schema.GetOffset(0xE6EB02CD5F2A883E));
  }
  public IPulse_ResumePoint OnTrue {
    get => new CPulse_ResumePoint(_Handle + Schema.GetOffset(0xE6EB02CD6EAE5D88));
  }


}