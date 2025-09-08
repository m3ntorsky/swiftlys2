using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSPlayer_BulletServices : CPlayerPawnComponent, ICSPlayer_BulletServices {

  public CCSPlayer_BulletServices(nint handle) : base(handle) {
  }



  public void TotalHitsOnServerUpdated() {
    Schema.Update(_Handle, 0x39B0E99E8006CF29);
  }
}