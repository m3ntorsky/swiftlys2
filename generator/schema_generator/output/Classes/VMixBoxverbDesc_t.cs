using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class VMixBoxverbDesc_t : SchemaClass, IVMixBoxverbDesc_t {

  public VMixBoxverbDesc_t(nint handle) : base(handle) {
  }

  public ref float SizeMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x70C7542DB9D7F5B8));
  }
  public ref float SizeMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x70C7542DAFEB6DB2));
  }
  public ref float Complexity {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x70C7542DF222266B));
  }
  public ref float Diffusion {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x70C7542DCDBE8936));
  }
  public ref float ModDepth {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x70C7542DF59E0B82));
  }
  public ref float ModRate {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x70C7542D0EA039FF));
  }
  public ref bool Parallel {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x70C7542D8971ED92));
  }
  public IVMixFilterDesc_t FilterType {
    get => new VMixFilterDesc_t(_Handle + Schema.GetOffset(0x70C7542D7E582F6F));
  }
  public ref float Width {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x70C7542DB91935E1));
  }
  public ref float Height {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x70C7542DEADD7FB0));
  }
  public ref float Depth {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x70C7542DD3AD54E8));
  }
  public ref float FeedbackScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x70C7542D2CE35D6E));
  }
  public ref float FeedbackWidth {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x70C7542D50275950));
  }
  public ref float FeedbackHeight {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x70C7542DFB780A47));
  }
  public ref float FeedbackDepth {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x70C7542DB71B2D09));
  }
  public ref float OutputGain {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x70C7542D73DB9445));
  }
  public ref float Taps {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x70C7542D5C502CB9));
  }


}