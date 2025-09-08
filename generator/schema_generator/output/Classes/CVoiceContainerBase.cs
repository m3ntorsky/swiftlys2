using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CVoiceContainerBase : SchemaClass, IVoiceContainerBase {

  public CVoiceContainerBase(nint handle) : base(handle) {
  }

  public IVSound Sound {
    get => new CVSound(_Handle + Schema.GetOffset(0x9D65DC3663C1A950));
  }
  public IVoiceContainerAnalysisBase EnvelopeAnalyzer {
    get => new CVoiceContainerAnalysisBase(_Handle + Schema.GetOffset(0x9D65DC362102947D));
  }


}