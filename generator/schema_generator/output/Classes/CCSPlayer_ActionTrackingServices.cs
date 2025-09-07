using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSPlayer_ActionTrackingServices : CPlayerPawnComponent, ICSPlayer_ActionTrackingServices {

  public CCSPlayer_ActionTrackingServices(nint handle) : base(handle) {
  }

  public CCSPlayer_ActionTrackingServices(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CHandle< CBasePlayerWeapon > LastWeaponBeforeC4AutoSwitch {
    get => ref _Handle.AsRef<CHandle< CBasePlayerWeapon >>(Schema.GetOffset(0xC890019D6687BAC0));
  }
  public ref bool IsRescuing {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC890019D225BDB2F));
  }
  public IWeaponPurchaseTracker_t WeaponPurchasesThisMatch {
    get => new WeaponPurchaseTracker_t(_Handle + Schema.GetOffset(0xC890019D43F68EE0));
  }
  public IWeaponPurchaseTracker_t WeaponPurchasesThisRound {
    get => new WeaponPurchaseTracker_t(_Handle + Schema.GetOffset(0xC890019D7C64F835));
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