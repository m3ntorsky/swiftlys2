using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_ExampleSelector : CPulseCell_BaseFlow, IPulseCell_ExampleSelector {

  public CPulseCell_ExampleSelector(nint handle) : base(handle) {
  }

  public CPulseCell_ExampleSelector(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IPulseSelectorOutflowList_t OutflowList {
    get => new PulseSelectorOutflowList_t(_Handle + Schema.GetOffset(0x97417F8B1461E743));
  }


}