using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Outflow_StringSwitch : CPulseCell_BaseFlow, IPulseCell_Outflow_StringSwitch {

  public CPulseCell_Outflow_StringSwitch(nint handle) : base(handle) {
  }

  public IPulse_OutflowConnection DefaultCaseOutflow {
    get => new CPulse_OutflowConnection(_Handle + Schema.GetOffset(0x74F0AF709EEF1E82));
  }
  public ref CUtlVector CaseOutflows {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x74F0AF70374F213C));
  }


}