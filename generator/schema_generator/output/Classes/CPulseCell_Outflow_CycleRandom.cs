using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Outflow_CycleRandom : CPulseCell_BaseFlow, IPulseCell_Outflow_CycleRandom {

  public CPulseCell_Outflow_CycleRandom(nint handle) : base(handle) {
  }

  public ref CUtlVector Outputs {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xF24A555AA38A89D5));
  }


}