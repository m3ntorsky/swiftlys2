using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class VMixDualCompressorDesc_t : SchemaClass, IVMixDualCompressorDesc_t {

  public VMixDualCompressorDesc_t(nint handle) : base(handle) {
  }

  public VMixDualCompressorDesc_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float RMSTimeMS {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6B9BDFD8FB749526));
  }
  public ref float FldbKneeWidth {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6B9BDFD835532FF2));
  }
  public ref float WetMix {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6B9BDFD8D5453C15));
  }
  public ref bool PeakMode {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6B9BDFD887DF35F9));
  }
  public IVMixDynamicsBand_t BandDesc {
    get => new VMixDynamicsBand_t(_Handle + Schema.GetOffset(0x6B9BDFD804203F47));
  }


}