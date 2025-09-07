using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_BaseLerp : CPulseCell_BaseYieldingInflow, IPulseCell_BaseLerp {

  public CPulseCell_BaseLerp(nint handle) : base(handle) {
  }

  public CPulseCell_BaseLerp(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IPulse_ResumePoint WakeResume {
    get => new CPulse_ResumePoint(_Handle + Schema.GetOffset(0x8AF2C31831F86DC2));
  }


}