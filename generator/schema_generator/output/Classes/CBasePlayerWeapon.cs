using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBasePlayerWeapon : CEconEntity, IBasePlayerWeapon {

  public CBasePlayerWeapon(nint handle) : base(handle) {
  }

  public CBasePlayerWeapon(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IGameTick_t NextPrimaryAttackTick {
    get => new GameTick_t(_Handle + Schema.GetOffset(0x4174B75E11BA24E3));
  }
  public ref float NextPrimaryAttackTickRatio {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4174B75E0D9A9E18));
  }
  public IGameTick_t NextSecondaryAttackTick {
    get => new GameTick_t(_Handle + Schema.GetOffset(0x4174B75EDE66C257));
  }
  public ref float NextSecondaryAttackTickRatio {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4174B75EF3E6AF88));
  }
  public ref int Clip1 {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x4174B75ED0250969));
  }
  public ref int Clip2 {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x4174B75ECD2504B0));
  }
  public ISchemaFixedArray<int32> ReserveAmmo {
    get => new SchemaFixedArray<int32>(_Handle + Schema.GetOffset(0x4174B75EB3FEBB0B));
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