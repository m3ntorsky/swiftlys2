using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class VMixDynamicsDesc_t : SchemaClass, IVMixDynamicsDesc_t {

  public VMixDynamicsDesc_t(nint handle) : base(handle) {
  }

  public ref float FldbGain {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC4119B7931BF2DF2));
  }
  public ref float FldbNoiseGateThreshold {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC4119B799838FE4D));
  }
  public ref float FldbCompressionThreshold {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC4119B79C45CDA7C));
  }
  public ref float FldbLimiterThreshold {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC4119B79CC95E7EA));
  }
  public ref float FldbKneeWidth {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC4119B7935532FF2));
  }
  public ref float Ratio {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC4119B79DEAD31EA));
  }
  public ref float LimiterRatio {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC4119B79A8D830FC));
  }
  public ref float AttackTimeMS {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC4119B79D4A28216));
  }
  public ref float ReleaseTimeMS {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC4119B79EBB62791));
  }
  public ref float RMSTimeMS {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC4119B79FB749526));
  }
  public ref float WetMix {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC4119B79D5453C15));
  }
  public ref bool PeakMode {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC4119B7987DF35F9));
  }


}