using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTestBlendContainer : CVoiceContainerBase, ITestBlendContainer {

  public CTestBlendContainer(nint handle) : base(handle) {
  }

  public CStrongHandle<IInfoForResourceTypeCVoiceContainerBase> FirstSound {
    get => new CStrongHandle<InfoForResourceTypeCVoiceContainerBase>(_Handle + Schema.GetOffset(0x3E7BF53C666B0138));
  }
  public CStrongHandle<IInfoForResourceTypeCVoiceContainerBase> SecondSound {
    get => new CStrongHandle<InfoForResourceTypeCVoiceContainerBase>(_Handle + Schema.GetOffset(0x3E7BF53CA2BC3E5C));
  }


}