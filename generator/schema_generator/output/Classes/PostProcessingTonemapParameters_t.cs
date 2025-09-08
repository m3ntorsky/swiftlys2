using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PostProcessingTonemapParameters_t : SchemaClass, IPostProcessingTonemapParameters_t {

  public PostProcessingTonemapParameters_t(nint handle) : base(handle) {
  }

  public ref float ExposureBias {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x62C7E951BBF57613));
  }
  public ref float ShoulderStrength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x62C7E951F177A3EE));
  }
  public ref float LinearStrength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x62C7E95172E93F83));
  }
  public ref float LinearAngle {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x62C7E951C16B14B1));
  }
  public ref float ToeStrength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x62C7E95168B1B908));
  }
  public ref float ToeNum {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x62C7E951DCB0097B));
  }
  public ref float ToeDenom {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x62C7E951FFD477EC));
  }
  public ref float WhitePoint {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x62C7E9518901AA8E));
  }
  public ref float LuminanceSource {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x62C7E9517B15A366));
  }
  public ref float ExposureBiasShadows {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x62C7E951958A1C90));
  }
  public ref float ExposureBiasHighlights {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x62C7E95105E519FE));
  }
  public ref float MinShadowLum {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x62C7E9511E2BE58D));
  }
  public ref float MaxShadowLum {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x62C7E951269F61AB));
  }
  public ref float MinHighlightLum {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x62C7E951A9EADF4F));
  }
  public ref float MaxHighlightLum {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x62C7E9516352B9A5));
  }


}