using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_PlaySequence : CPulseCell_BaseYieldingInflow, IPulseCell_PlaySequence {

  public CPulseCell_PlaySequence(nint handle) : base(handle) {
  }

  public ref CUtlString SequenceName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xE313765BA270F66B));
  }
  public IPulseNodeDynamicOutflows_t PulseAnimEvents {
    get => new PulseNodeDynamicOutflows_t(_Handle + Schema.GetOffset(0xE313765B10F0A082));
  }
  public IPulse_ResumePoint OnFinished {
    get => new CPulse_ResumePoint(_Handle + Schema.GetOffset(0xE313765B8D903E5E));
  }
  public IPulse_ResumePoint OnCanceled {
    get => new CPulse_ResumePoint(_Handle + Schema.GetOffset(0xE313765BF02162DB));
  }


}