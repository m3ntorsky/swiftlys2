using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFogController : CBaseEntity, IFogController {

  public CFogController(nint handle) : base(handle) {
  }

  public CFogController(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public Ifogparams_t Fog {
    get => new fogparams_t(_Handle + Schema.GetOffset(0x719804B29014635F));
  }
  public ref bool UseAngles {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x719804B2434C3DB4));
  }
  public ref int ChangedVariables {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x719804B2BC173F39));
  }

  public void FogUpdated() {
    Schema.Update(_Handle, 0x719804B29014635F);
  }
}