using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class VMixDynamics3BandDesc_t : SchemaClass, IVMixDynamics3BandDesc_t {

  public VMixDynamics3BandDesc_t(nint handle) : base(handle) {
  }

  public ref float FldbGainOutput {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA4A1000DFC3C16D3));
  }
  public ref float RMSTimeMS {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA4A1000DFB749526));
  }
  public ref float FldbKneeWidth {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA4A1000D35532FF2));
  }
  public ref float Depth {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA4A1000DD3AD54E8));
  }
  public ref float WetMix {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA4A1000DD5453C15));
  }
  public ref float TimeScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA4A1000DB49D735C));
  }
  public ref float LowCutoffFreq {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA4A1000D1E9A1CCC));
  }
  public ref float HighCutoffFreq {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA4A1000D3FE556C8));
  }
  public ref bool PeakMode {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA4A1000D87DF35F9));
  }
  public IVMixDynamicsBand_t BandDesc {
    get => new VMixDynamicsBand_t(_Handle, 0xA4A1000D04203F47, 3, 36, 4);
  }


}