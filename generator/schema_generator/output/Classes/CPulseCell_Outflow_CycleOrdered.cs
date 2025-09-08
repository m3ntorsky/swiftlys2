using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Outflow_CycleOrdered : CPulseCell_BaseFlow, IPulseCell_Outflow_CycleOrdered {

  public CPulseCell_Outflow_CycleOrdered(nint handle) : base(handle) {
  }

  public ref CUtlVector Outputs {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xAED1209EA38A89D5));
  }


}