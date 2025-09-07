using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Timeline__TimelineEvent_t : SchemaClass, IPulseCell_Timeline__TimelineEvent_t {

  public CPulseCell_Timeline__TimelineEvent_t(nint handle) : base(handle) {
  }

  public CPulseCell_Timeline__TimelineEvent_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float TimeFromPrevious {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1CEAA89BD23FC4AF));
  }
  public IPulse_OutflowConnection EventOutflow {
    get => new CPulse_OutflowConnection(_Handle + Schema.GetOffset(0x1CEAA89BC72D3231));
  }


}