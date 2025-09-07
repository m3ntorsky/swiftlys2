using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEnvDetailController : CBaseEntity, IEnvDetailController {

  public CEnvDetailController(nint handle) : base(handle) {
  }

  public CEnvDetailController(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float FadeStartDist {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x585A7964FBFACAF3));
  }
  public ref float FadeEndDist {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x585A79646DD6252A));
  }

  public void FadeStartDistUpdated() {
    Schema.Update(_Handle, 0x585A7964FBFACAF3);
  }
  public void FadeEndDistUpdated() {
    Schema.Update(_Handle, 0x585A79646DD6252A);
  }
}