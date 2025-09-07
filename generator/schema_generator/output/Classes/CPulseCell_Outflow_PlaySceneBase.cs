using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Outflow_PlaySceneBase : CPulseCell_BaseYieldingInflow, IPulseCell_Outflow_PlaySceneBase {

  public CPulseCell_Outflow_PlaySceneBase(nint handle) : base(handle) {
  }

  public CPulseCell_Outflow_PlaySceneBase(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IPulse_ResumePoint OnFinished {
    get => new CPulse_ResumePoint(_Handle + Schema.GetOffset(0x647C41D08D903E5E));
  }
  public IPulse_ResumePoint OnCanceled {
    get => new CPulse_ResumePoint(_Handle + Schema.GetOffset(0x647C41D0F02162DB));
  }
  public ref CUtlVector< CPulse_OutflowConnection > Triggers {
    get => ref _Handle.AsRef<CUtlVector< CPulse_OutflowConnection >>(Schema.GetOffset(0x647C41D06E7B12D0));
  }


}