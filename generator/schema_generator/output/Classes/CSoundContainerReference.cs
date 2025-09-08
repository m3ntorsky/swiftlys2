using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSoundContainerReference : SchemaClass, ISoundContainerReference {

  public CSoundContainerReference(nint handle) : base(handle) {
  }

  public ref bool UseReference {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x4663CCA145BCD5C9));
  }
  public ref CStrongHandle<InfoForResourceTypeCVoiceContainerBase> Sound {
    get => ref _Handle.AsRef<CStrongHandle<InfoForResourceTypeCVoiceContainerBase>>(Schema.GetOffset(0x4663CCA14E1C4FB4));
  }
  public IVoiceContainerBase Sound {
    get => new CVoiceContainerBase(_Handle + Schema.GetOffset(0x4663CCA13D8D58B6));
  }


}