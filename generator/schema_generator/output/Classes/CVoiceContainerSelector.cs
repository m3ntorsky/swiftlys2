using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CVoiceContainerSelector : CVoiceContainerBase, IVoiceContainerSelector {

  public CVoiceContainerSelector(nint handle) : base(handle) {
  }

  public ref PlayBackMode_t Mode {
    get => ref _Handle.AsRef<PlayBackMode_t>(Schema.GetOffset(0xF16C473A90FD5BB2));
  }
  public ISoundContainerReferenceArray SoundsToPlay {
    get => new CSoundContainerReferenceArray(_Handle + Schema.GetOffset(0xF16C473ADCB5F70E));
  }
  public ref CUtlVector<float> ProbabilityWeights {
    get => ref _Handle.AsRef<CUtlVector<float>>(Schema.GetOffset(0xF16C473A6DABFC99));
  }


}