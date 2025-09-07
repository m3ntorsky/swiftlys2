using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Outflow_TestRandomYesNo : CPulseCell_BaseFlow, IPulseCell_Outflow_TestRandomYesNo {

  public CPulseCell_Outflow_TestRandomYesNo(nint handle) : base(handle) {
  }

  public CPulseCell_Outflow_TestRandomYesNo(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IPulse_OutflowConnection Yes {
    get => new CPulse_OutflowConnection(_Handle + Schema.GetOffset(0x9EA5F31EDA358F10));
  }
  public IPulse_OutflowConnection No {
    get => new CPulse_OutflowConnection(_Handle + Schema.GetOffset(0x9EA5F31EE004A07A));
  }


}