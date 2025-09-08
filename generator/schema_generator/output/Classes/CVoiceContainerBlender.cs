using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CVoiceContainerBlender : CVoiceContainerBase, IVoiceContainerBlender {

  public CVoiceContainerBlender(nint handle) : base(handle) {
  }

  public ISoundContainerReference FirstSound {
    get => new CSoundContainerReference(_Handle + Schema.GetOffset(0xB05752DD666B0138));
  }
  public ISoundContainerReference SecondSound {
    get => new CSoundContainerReference(_Handle + Schema.GetOffset(0xB05752DDA2BC3E5C));
  }
  public ref float BlendFactor {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB05752DDFF4DA451));
  }


}