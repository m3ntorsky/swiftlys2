using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSPlayer_ActionTrackingServices : CPlayerPawnComponent, ICSPlayer_ActionTrackingServices {

  public CCSPlayer_ActionTrackingServices(nint handle) : base(handle) {
  }

  public CHandle<IBasePlayerWeapon> LastWeaponBeforeC4AutoSwitch {
    get => new CHandle<CBasePlayerWeapon>(_Handle + Schema.GetOffset(0xC890019D6687BAC0));
  }

  public void IsRescuingUpdated() {
    Schema.Update(_Handle, 0xC890019D225BDB2F);
  }
  public void WeaponPurchasesThisMatchUpdated() {
    Schema.Update(_Handle, 0xC890019D43F68EE0);
  }
  public void WeaponPurchasesThisRoundUpdated() {
    Schema.Update(_Handle, 0xC890019D7C64F835);
  }
}