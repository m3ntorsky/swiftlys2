using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Inflow_Wait : CPulseCell_BaseYieldingInflow, IPulseCell_Inflow_Wait {

  public CPulseCell_Inflow_Wait(nint handle) : base(handle) {
  }

  public IPulse_ResumePoint WakeResume {
    get => new CPulse_ResumePoint(_Handle + Schema.GetOffset(0x8A00D13D31F86DC2));
  }


}