using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Outflow_ScriptedSequence : CPulseCell_BaseYieldingInflow, IPulseCell_Outflow_ScriptedSequence {

  public CPulseCell_Outflow_ScriptedSequence(nint handle) : base(handle) {
  }

  public ref CUtlString SyncGroup {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x462EA7DEF9E8183A));
  }
  public ref int ExpectedNumSequencesInSyncGroup {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x462EA7DE0C6AAD7A));
  }
  public ref bool EnsureOnNavmeshOnFinish {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x462EA7DE802BA0B0));
  }
  public ref bool DontTeleportAtEnd {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x462EA7DE59E02641));
  }
  public ref bool DisallowInterrupts {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x462EA7DE939D3840));
  }
  public IPulseScriptedSequenceData_t ScriptedSequenceDataMain {
    get => new PulseScriptedSequenceData_t(_Handle + Schema.GetOffset(0x462EA7DE03F2FF03));
  }
  public ref CUtlVector AdditionalActors {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x462EA7DE8E5DB532));
  }
  public IPulse_ResumePoint OnFinished {
    get => new CPulse_ResumePoint(_Handle + Schema.GetOffset(0x462EA7DE8D903E5E));
  }
  public IPulse_ResumePoint OnCanceled {
    get => new CPulse_ResumePoint(_Handle + Schema.GetOffset(0x462EA7DEF02162DB));
  }
  public ref CUtlVector Triggers {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x462EA7DE6E7B12D0));
  }


}