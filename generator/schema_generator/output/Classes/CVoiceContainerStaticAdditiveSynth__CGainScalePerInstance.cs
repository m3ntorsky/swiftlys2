using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CVoiceContainerStaticAdditiveSynth__CGainScalePerInstance : SchemaClass, IVoiceContainerStaticAdditiveSynth__CGainScalePerInstance {

  public CVoiceContainerStaticAdditiveSynth__CGainScalePerInstance(nint handle) : base(handle) {
  }

  public CVoiceContainerStaticAdditiveSynth__CGainScalePerInstance(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float MinVolume {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9089F81B2CA4E2A3));
  }
  public ref int InstancesAtMinVolume {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x9089F81BBA3DF3B8));
  }
  public ref float MaxVolume {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9089F81B25691B11));
  }
  public ref int InstancesAtMaxVolume {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x9089F81B18EB3E46));
  }


}