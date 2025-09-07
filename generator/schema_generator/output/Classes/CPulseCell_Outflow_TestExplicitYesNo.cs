using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Outflow_TestExplicitYesNo : CPulseCell_BaseFlow, IPulseCell_Outflow_TestExplicitYesNo {

  public CPulseCell_Outflow_TestExplicitYesNo(nint handle) : base(handle) {
  }

  public CPulseCell_Outflow_TestExplicitYesNo(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IPulse_OutflowConnection Yes {
    get => new CPulse_OutflowConnection(_Handle + Schema.GetOffset(0xA1B4A577DA358F10));
  }
  public IPulse_OutflowConnection No {
    get => new CPulse_OutflowConnection(_Handle + Schema.GetOffset(0xA1B4A577E004A07A));
  }


}