using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEnvDetailController : CBaseEntity, IEnvDetailController {

  public CEnvDetailController(nint handle) : base(handle) {
  }



  public void FadeStartDistUpdated() {
    Schema.Update(_Handle, 0x585A7964FBFACAF3);
  }
  public void FadeEndDistUpdated() {
    Schema.Update(_Handle, 0x585A79646DD6252A);
  }
}