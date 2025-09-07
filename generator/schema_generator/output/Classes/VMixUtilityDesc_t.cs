using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class VMixUtilityDesc_t : SchemaClass, IVMixUtilityDesc_t {

  public VMixUtilityDesc_t(nint handle) : base(handle) {
  }

  public VMixUtilityDesc_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref VMixChannelOperation_t Op {
    get => ref _Handle.AsRef<VMixChannelOperation_t>(Schema.GetOffset(0x9B3640C11384687E));
  }
  public ref float InputPan {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9B3640C17E813E04));
  }
  public ref float OutputBalance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9B3640C1730ED266));
  }
  public ref float FldbOutputGain {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9B3640C167F97C23));
  }
  public ref bool BassMono {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9B3640C1C65EDB7D));
  }
  public ref float BassFreq {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9B3640C13E71CC5A));
  }


}