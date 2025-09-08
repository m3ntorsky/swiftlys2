using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CVoiceContainerLoopTrigger : CVoiceContainerBase, IVoiceContainerLoopTrigger {

  public CVoiceContainerLoopTrigger(nint handle) : base(handle) {
  }

  public ISoundContainerReference Sound {
    get => new CSoundContainerReference(_Handle + Schema.GetOffset(0x1A1BEAF4E1C4FB4));
  }
  public ref float RetriggerTimeMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1A1BEAFE6138381));
  }
  public ref float RetriggerTimeMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1A1BEAFD828882F));
  }
  public ref float FadeTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1A1BEAF00BEDB08));
  }
  public ref bool CrossFade {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1A1BEAF64BEC665));
  }


}