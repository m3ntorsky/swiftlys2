using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class VMixPannerDesc_t : SchemaClass, IVMixPannerDesc_t {

  public VMixPannerDesc_t(nint handle) : base(handle) {
  }

  public ref VMixPannerType_t Type {
    get => ref _Handle.AsRef<VMixPannerType_t>(Schema.GetOffset(0x13827FF70F04B4ED));
  }
  public ref float Strength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x13827FF78F67AF1A));
  }


}