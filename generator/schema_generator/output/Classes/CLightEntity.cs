using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CLightEntity : CBaseModelEntity, ILightEntity {

  public CLightEntity(nint handle) : base(handle) {
  }

  public CLightEntity(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ILightComponent CLightComponent {
    get => new CLightComponent(_Handle + Schema.GetOffset(0xA3C95F05104F0185));
  }

  public void CLightComponentUpdated() {
    Schema.Update(_Handle, 0xA3C95F05104F0185);
  }
}