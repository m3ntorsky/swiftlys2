using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_FadeAndKillForTracers : CParticleFunctionOperator, IC_OP_FadeAndKillForTracers {

  public C_OP_FadeAndKillForTracers(nint handle) : base(handle) {
  }

  public ref float StartFadeInTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x776267EF39639779));
  }
  public ref float EndFadeInTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x776267EF36A35C84));
  }
  public ref float StartFadeOutTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x776267EF6ABCF324));
  }
  public ref float EndFadeOutTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x776267EFFE87D7E7));
  }
  public ref float StartAlpha {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x776267EF6A7A5D0B));
  }
  public ref float EndAlpha {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x776267EF7A639CC0));
  }


}