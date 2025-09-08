using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEnvFade : CLogicalEntity, IEnvFade {

  public CEnvFade(nint handle) : base(handle) {
  }

  public ref float Duration {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xEFBFC0639879A98D));
  }
  public ref float HoldDuration {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xEFBFC0631D577A68));
  }
  public IEntityIOOutput OnBeginFade {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xEFBFC0633308BA63));
  }

  public void FadeColorUpdated() {
    Schema.Update(_Handle, 0xEFBFC063C1517BF2);
  }
}