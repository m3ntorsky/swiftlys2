using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class VMixVocoderDesc_t : SchemaClass, IVMixVocoderDesc_t {

  public VMixVocoderDesc_t(nint handle) : base(handle) {
  }

  public ref int BandCount {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xFBAB3A2972E16EF9));
  }
  public ref float Bandwidth {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xFBAB3A29BB43932C));
  }
  public ref float FldBModGain {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xFBAB3A291EEAC180));
  }
  public ref float FreqRangeStart {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xFBAB3A29B4752A4E));
  }
  public ref float FreqRangeEnd {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xFBAB3A29884ECF5B));
  }
  public ref float FldBUnvoicedGain {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xFBAB3A29B45A3DEF));
  }
  public ref float AttackTimeMS {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xFBAB3A29D4A28216));
  }
  public ref float ReleaseTimeMS {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xFBAB3A29EBB62791));
  }
  public ref int DebugBand {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xFBAB3A296E77C31B));
  }
  public ref bool PeakMode {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xFBAB3A2987DF35F9));
  }


}