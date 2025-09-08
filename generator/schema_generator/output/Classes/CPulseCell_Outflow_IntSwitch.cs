using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Outflow_IntSwitch : CPulseCell_BaseFlow, IPulseCell_Outflow_IntSwitch {

  public CPulseCell_Outflow_IntSwitch(nint handle) : base(handle) {
  }

  public IPulse_OutflowConnection DefaultCaseOutflow {
    get => new CPulse_OutflowConnection(_Handle + Schema.GetOffset(0x50C7C8629EEF1E82));
  }
  public ref CUtlVector CaseOutflows {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x50C7C862374F213C));
  }


}