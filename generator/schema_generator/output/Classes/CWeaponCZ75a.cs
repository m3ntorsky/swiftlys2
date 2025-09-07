using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CWeaponCZ75a : CCSWeaponBaseGun, IWeaponCZ75a {

  public CWeaponCZ75a(nint handle) : base(handle) {
  }

  public CWeaponCZ75a(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref bool MagazineRemoved {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x5FFE9C69188A471));
  }

  public void MagazineRemovedUpdated() {
    Schema.Update(_Handle, 0x5FFE9C69188A471);
  }
}