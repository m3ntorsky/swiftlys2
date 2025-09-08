using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CVoiceContainerEnvelope : CVoiceContainerBase, IVoiceContainerEnvelope {

  public CVoiceContainerEnvelope(nint handle) : base(handle) {
  }

  public CStrongHandle<IInfoForResourceTypeCVoiceContainerBase> Sound {
    get => new CStrongHandle<InfoForResourceTypeCVoiceContainerBase>(_Handle + Schema.GetOffset(0x5CEF97E74E1C4FB4));
  }
  public IVoiceContainerAnalysisBase AnalysisContainer {
    get => new CVoiceContainerAnalysisBase(_Handle + Schema.GetOffset(0x5CEF97E74C85F50E));
  }


}