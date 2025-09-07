using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class VMixSubgraphSwitchDesc_t : SchemaClass, IVMixSubgraphSwitchDesc_t {

  public VMixSubgraphSwitchDesc_t(nint handle) : base(handle) {
  }

  public VMixSubgraphSwitchDesc_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref VMixSubgraphSwitchInterpolationType_t InterpolationMode {
    get => ref _Handle.AsRef<VMixSubgraphSwitchInterpolationType_t>(Schema.GetOffset(0x9671DF890C06348A));
  }
  public ref bool OnlyTailsOnFadeOut {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9671DF89B74519D7));
  }
  public ref float InterpolationTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9671DF896D3B0FB6));
  }


}