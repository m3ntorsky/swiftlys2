using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBasePlayerWeapon : CEconEntity, IBasePlayerWeapon {

  public CBasePlayerWeapon(nint handle) : base(handle) {
  }

  public IEntityIOOutput OnPlayerUse {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x4174B75E611C9A14));
  }

  public void NextPrimaryAttackTickUpdated() {
    Schema.Update(_Handle, 0x4174B75E11BA24E3);
  }
  public void NextPrimaryAttackTickRatioUpdated() {
    Schema.Update(_Handle, 0x4174B75E0D9A9E18);
  }
  public void NextSecondaryAttackTickUpdated() {
    Schema.Update(_Handle, 0x4174B75EDE66C257);
  }
  public void NextSecondaryAttackTickRatioUpdated() {
    Schema.Update(_Handle, 0x4174B75EF3E6AF88);
  }
  public void Clip1Updated() {
    Schema.Update(_Handle, 0x4174B75ED0250969);
  }
  public void Clip2Updated() {
    Schema.Update(_Handle, 0x4174B75ECD2504B0);
  }
  public void ReserveAmmoUpdated() {
    Schema.Update(_Handle, 0x4174B75EB3FEBB0B);
  }
}