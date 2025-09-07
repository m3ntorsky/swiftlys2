using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTestBlendContainer : CVoiceContainerBase, ITestBlendContainer {

  public CTestBlendContainer(nint handle) : base(handle) {
  }

  public CTestBlendContainer(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CStrongHandle< InfoForResourceTypeCVoiceContainerBase > FirstSound {
    get => ref _Handle.AsRef<CStrongHandle< InfoForResourceTypeCVoiceContainerBase >>(Schema.GetOffset(0x3E7BF53C666B0138));
  }
  public ref CStrongHandle< InfoForResourceTypeCVoiceContainerBase > SecondSound {
    get => ref _Handle.AsRef<CStrongHandle< InfoForResourceTypeCVoiceContainerBase >>(Schema.GetOffset(0x3E7BF53CA2BC3E5C));
  }


}