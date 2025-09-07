using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class VMixShaperDesc_t : SchemaClass, IVMixShaperDesc_t {

  public VMixShaperDesc_t(nint handle) : base(handle) {
  }

  public VMixShaperDesc_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int Shape {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x80E2A73621208A02));
  }
  public ref float FldbDrive {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x80E2A7360E12679B));
  }
  public ref float FldbOutputGain {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x80E2A73667F97C23));
  }
  public ref float WetMix {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x80E2A736D5453C15));
  }
  public ref int OversampleFactor {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x80E2A736142D0AF2));
  }


}