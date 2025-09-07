using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class VMixFilterDesc_t : SchemaClass, IVMixFilterDesc_t {

  public VMixFilterDesc_t(nint handle) : base(handle) {
  }

  public VMixFilterDesc_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref VMixFilterType_t FilterType {
    get => ref _Handle.AsRef<VMixFilterType_t>(Schema.GetOffset(0x39A87B6971861EDB));
  }
  public ref VMixFilterSlope_t FilterSlope {
    get => ref _Handle.AsRef<VMixFilterSlope_t>(Schema.GetOffset(0x39A87B696387D992));
  }
  public ref bool Enabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x39A87B696154EB7E));
  }
  public ref float FldbGain {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x39A87B6931BF2DF2));
  }
  public ref float CutoffFreq {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x39A87B691E8CBE8C));
  }
  public ref float Q {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x39A87B6996122E3A));
  }


}