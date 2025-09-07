using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Inflow_Yield : CPulseCell_BaseYieldingInflow, IPulseCell_Inflow_Yield {

  public CPulseCell_Inflow_Yield(nint handle) : base(handle) {
  }

  public CPulseCell_Inflow_Yield(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IPulse_ResumePoint UnyieldResume {
    get => new CPulse_ResumePoint(_Handle + Schema.GetOffset(0x1A4BFE3D504DFCDC));
  }


}