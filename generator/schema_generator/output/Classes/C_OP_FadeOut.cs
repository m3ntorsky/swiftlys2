using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_FadeOut : CParticleFunctionOperator, IC_OP_FadeOut {

  public C_OP_FadeOut(nint handle) : base(handle) {
  }

  public C_OP_FadeOut(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float FadeOutTimeMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDB3026B50D900CF6));
  }
  public ref float FadeOutTimeMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDB3026B5FFA37EA4));
  }
  public ref float FadeOutTimeExp {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDB3026B596AB9995));
  }
  public ref float FadeBias {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDB3026B5D35FA840));
  }
  public ref bool Proportional {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xDB3026B5891F328A));
  }
  public ref bool EaseInAndOut {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xDB3026B5D14612BF));
  }


}