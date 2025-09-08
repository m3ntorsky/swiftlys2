using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class VMixEffectChainDesc_t : SchemaClass, IVMixEffectChainDesc_t {

  public VMixEffectChainDesc_t(nint handle) : base(handle) {
  }

  public ref float CrossfadeTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x993FEE3C5C1DD52));
  }


}