using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmIKRig : SchemaClass, INmIKRig {

  public CNmIKRig(nint handle) : base(handle) {
  }

  public ref CStrongHandle<InfoForResourceTypeCNmSkeleton> Skeleton {
    get => ref _Handle.AsRef<CStrongHandle<InfoForResourceTypeCNmSkeleton>>(Schema.GetOffset(0x9C509BCFE77F030E));
  }
  public ref CUtlVector Bodies {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x9C509BCF24483A49));
  }
  public ref CUtlVector Joints {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x9C509BCF364EA4AC));
  }


}