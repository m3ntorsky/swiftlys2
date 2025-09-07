using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSPlayer_HostageServices : CPlayerPawnComponent, ICSPlayer_HostageServices {

  public CCSPlayer_HostageServices(nint handle) : base(handle) {
  }

  public CCSPlayer_HostageServices(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CHandle< CBaseEntity > CarriedHostage {
    get => ref _Handle.AsRef<CHandle< CBaseEntity >>(Schema.GetOffset(0x1742920F695FDF3C));
  }
  public ref CHandle< CBaseEntity > CarriedHostageProp {
    get => ref _Handle.AsRef<CHandle< CBaseEntity >>(Schema.GetOffset(0x1742920F7270EB65));
  }

  public void CarriedHostageUpdated() {
    Schema.Update(_Handle, 0x1742920F695FDF3C);
  }
  public void CarriedHostagePropUpdated() {
    Schema.Update(_Handle, 0x1742920F7270EB65);
  }
}