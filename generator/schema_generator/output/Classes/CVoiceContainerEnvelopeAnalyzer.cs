using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CVoiceContainerEnvelopeAnalyzer : CVoiceContainerAnalysisBase, IVoiceContainerEnvelopeAnalyzer {

  public CVoiceContainerEnvelopeAnalyzer(nint handle) : base(handle) {
  }

  public ref EMode_t Mode {
    get => ref _Handle.AsRef<EMode_t>(Schema.GetOffset(0xC5D0FF1990FD5BB2));
  }
  public ref float AnalysisWindowMs {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC5D0FF198349BF07));
  }
  public ref float Threshold {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC5D0FF197872FFEA));
  }


}