using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Timeline : CPulseCell_BaseYieldingInflow, IPulseCell_Timeline {

  public CPulseCell_Timeline(nint handle) : base(handle) {
  }

  public ref CUtlVector TimelineEvents {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xF1185F93C91CDDC3));
  }
  public ref bool WaitForChildOutflows {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xF1185F933F8E29C6));
  }
  public IPulse_ResumePoint OnFinished {
    get => new CPulse_ResumePoint(_Handle + Schema.GetOffset(0xF1185F938D903E5E));
  }
  public IPulse_ResumePoint OnCanceled {
    get => new CPulse_ResumePoint(_Handle + Schema.GetOffset(0xF1185F93F02162DB));
  }


}