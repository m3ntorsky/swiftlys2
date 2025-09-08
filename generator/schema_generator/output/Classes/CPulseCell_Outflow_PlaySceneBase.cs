using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Outflow_PlaySceneBase : CPulseCell_BaseYieldingInflow, IPulseCell_Outflow_PlaySceneBase {

  public CPulseCell_Outflow_PlaySceneBase(nint handle) : base(handle) {
  }

  public IPulse_ResumePoint OnFinished {
    get => new CPulse_ResumePoint(_Handle + Schema.GetOffset(0x647C41D08D903E5E));
  }
  public IPulse_ResumePoint OnCanceled {
    get => new CPulse_ResumePoint(_Handle + Schema.GetOffset(0x647C41D0F02162DB));
  }
  public ref CUtlVector Triggers {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x647C41D06E7B12D0));
  }


}