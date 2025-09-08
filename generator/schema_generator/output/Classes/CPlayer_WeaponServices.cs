using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPlayer_WeaponServices : CPlayerPawnComponent, IPlayer_WeaponServices {

  public CPlayer_WeaponServices(nint handle) : base(handle) {
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