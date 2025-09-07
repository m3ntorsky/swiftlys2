using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_PickBestOutflowSelector : CPulseCell_BaseFlow, IPulseCell_PickBestOutflowSelector {

  public CPulseCell_PickBestOutflowSelector(nint handle) : base(handle) {
  }

  public CPulseCell_PickBestOutflowSelector(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref PulseBestOutflowRules_t CheckType {
    get => ref _Handle.AsRef<PulseBestOutflowRules_t>(Schema.GetOffset(0x7239DF04A94C6E6B));
  }
  public IPulseSelectorOutflowList_t OutflowList {
    get => new PulseSelectorOutflowList_t(_Handle + Schema.GetOffset(0x7239DF041461E743));
  }


}