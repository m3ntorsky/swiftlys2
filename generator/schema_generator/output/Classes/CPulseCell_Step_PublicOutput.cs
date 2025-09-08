using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Step_PublicOutput : CPulseCell_BaseFlow, IPulseCell_Step_PublicOutput {

  public CPulseCell_Step_PublicOutput(nint handle) : base(handle) {
  }

  public IPulseRuntimeOutputIndex_t OutputIndex {
    get => new PulseRuntimeOutputIndex_t(_Handle + Schema.GetOffset(0x40053C931E4D5BA0));
  }


}