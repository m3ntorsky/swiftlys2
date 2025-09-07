using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class VMixDelayDesc_t : SchemaClass, IVMixDelayDesc_t {

  public VMixDelayDesc_t(nint handle) : base(handle) {
  }

  public VMixDelayDesc_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IVMixFilterDesc_t FeedbackFilter {
    get => new VMixFilterDesc_t(_Handle + Schema.GetOffset(0x4C891F427C227CDC));
  }
  public ref bool EnableFilter {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x4C891F42A12F9BE8));
  }
  public ref float Delay {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4C891F427D68FD6E));
  }
  public ref float DirectGain {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4C891F42C6ABC039));
  }
  public ref float DelayGain {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4C891F42708E6A21));
  }
  public ref float FeedbackGain {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4C891F427CACF477));
  }
  public ref float Width {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4C891F42B91935E1));
  }


}