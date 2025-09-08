using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_TestWaitWithCursorState : CPulseCell_BaseYieldingInflow, IPulseCell_TestWaitWithCursorState {

  public CPulseCell_TestWaitWithCursorState(nint handle) : base(handle) {
  }

  public IPulse_ResumePoint WakeResume {
    get => new CPulse_ResumePoint(_Handle + Schema.GetOffset(0xB1305BB431F86DC2));
  }
  public IPulse_ResumePoint WakeCancel {
    get => new CPulse_ResumePoint(_Handle + Schema.GetOffset(0xB1305BB47C373223));
  }
  public IPulse_ResumePoint WakeFail {
    get => new CPulse_ResumePoint(_Handle + Schema.GetOffset(0xB1305BB4BE921FF5));
  }


}