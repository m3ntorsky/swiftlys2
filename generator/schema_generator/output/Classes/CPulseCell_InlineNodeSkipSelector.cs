using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_InlineNodeSkipSelector : CPulseCell_BaseFlow, IPulseCell_InlineNodeSkipSelector {

  public CPulseCell_InlineNodeSkipSelector(nint handle) : base(handle) {
  }

  public CPulseCell_InlineNodeSkipSelector(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IPulseDocNodeID_t FlowNodeID {
    get => new PulseDocNodeID_t(_Handle + Schema.GetOffset(0x43AF14578ED47FBC));
  }
  public ref bool And {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x43AF14573A289986));
  }
  public IPulseSelectorOutflowList_t PassOutflow {
    get => new PulseSelectorOutflowList_t(_Handle + Schema.GetOffset(0x43AF145724AA6434));
  }
  public IPulse_OutflowConnection FailOutflow {
    get => new CPulse_OutflowConnection(_Handle + Schema.GetOffset(0x43AF1457AC90C0E3));
  }


}