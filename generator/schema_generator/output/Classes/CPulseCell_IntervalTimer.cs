using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_IntervalTimer : CPulseCell_BaseYieldingInflow, IPulseCell_IntervalTimer {

  public CPulseCell_IntervalTimer(nint handle) : base(handle) {
  }

  public CPulseCell_IntervalTimer(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IPulse_ResumePoint Completed {
    get => new CPulse_ResumePoint(_Handle + Schema.GetOffset(0x33EF5E76818C0E92));
  }
  public ISignatureOutflow_Continue OnInterval {
    get => new SignatureOutflow_Continue(_Handle + Schema.GetOffset(0x33EF5E761A4FEF89));
  }


}