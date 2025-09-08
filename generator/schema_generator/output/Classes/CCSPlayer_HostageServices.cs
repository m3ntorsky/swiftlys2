using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSPlayer_HostageServices : CPlayerPawnComponent, ICSPlayer_HostageServices {

  public CCSPlayer_HostageServices(nint handle) : base(handle) {
  }



  public void CarriedHostageUpdated() {
    Schema.Update(_Handle, 0x1742920F695FDF3C);
  }
  public void CarriedHostagePropUpdated() {
    Schema.Update(_Handle, 0x1742920F7270EB65);
  }
}