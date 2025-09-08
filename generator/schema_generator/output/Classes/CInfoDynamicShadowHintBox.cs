using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CInfoDynamicShadowHintBox : CInfoDynamicShadowHint, IInfoDynamicShadowHintBox {

  public CInfoDynamicShadowHintBox(nint handle) : base(handle) {
  }

  public ref Vector BoxMins {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xFD9FEBD8201373));
  }
  public ref Vector BoxMaxs {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xFD9FEB817A3B31));
  }


}