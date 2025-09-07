using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPlayer_WeaponServices : CPlayerPawnComponent, IPlayer_WeaponServices {

  public CPlayer_WeaponServices(nint handle) : base(handle) {
  }

  public CPlayer_WeaponServices(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< CHandle< CBasePlayerWeapon > > MyWeapons {
    get => ref _Handle.AsRef<CUtlVector< CHandle< CBasePlayerWeapon > >>(Schema.GetOffset(0x634D22804C8A13A6));
  }
  public ref CHandle< CBasePlayerWeapon > ActiveWeapon {
    get => ref _Handle.AsRef<CHandle< CBasePlayerWeapon >>(Schema.GetOffset(0x634D2280940131C5));
  }
  public ref CHandle< CBasePlayerWeapon > LastWeapon {
    get => ref _Handle.AsRef<CHandle< CBasePlayerWeapon >>(Schema.GetOffset(0x634D2280EA5C9547));
  }
  public ISchemaFixedArray<uint16> Ammo {
    get => new SchemaFixedArray<uint16>(_Handle + Schema.GetOffset(0x634D22800D59E6CA));
  }
  public ref bool PreventWeaponPickup {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x634D228093894029));
  }

  public void MyWeaponsUpdated() {
    Schema.Update(_Handle, 0x634D22804C8A13A6);
  }
  public void ActiveWeaponUpdated() {
    Schema.Update(_Handle, 0x634D2280940131C5);
  }
  public void LastWeaponUpdated() {
    Schema.Update(_Handle, 0x634D2280EA5C9547);
  }
  public void AmmoUpdated() {
    Schema.Update(_Handle, 0x634D22800D59E6CA);
  }
}