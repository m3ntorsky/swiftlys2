using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CVoiceContainerRandomSampler : CVoiceContainerBase, IVoiceContainerRandomSampler {

  public CVoiceContainerRandomSampler(nint handle) : base(handle) {
  }

  public CVoiceContainerRandomSampler(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float Amplitude {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDCA93E5CB44B0E18));
  }
  public ref float AmplitudeJitter {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDCA93E5C108296CE));
  }
  public ref float TimeJitter {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDCA93E5C70047B44));
  }
  public ref float MaxLength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDCA93E5C87A8B4C7));
  }
  public ref int NumDelayVariations {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xDCA93E5C9356280C));
  }
  public ref CUtlVector< CStrongHandle< InfoForResourceTypeCVoiceContainerBase > > GrainResources {
    get => ref _Handle.AsRef<CUtlVector< CStrongHandle< InfoForResourceTypeCVoiceContainerBase > >>(Schema.GetOffset(0xDCA93E5C95692BB9));
  }


}