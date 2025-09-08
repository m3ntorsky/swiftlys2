using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CLightEntity : CBaseModelEntity, ILightEntity {

  public CLightEntity(nint handle) : base(handle) {
  }



  public void CLightComponentUpdated() {
    Schema.Update(_Handle, 0xA3C95F05104F0185);
  }
}