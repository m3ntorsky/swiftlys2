using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CWeaponSG556 : CCSWeaponBaseGun, IWeaponSG556 {

  public CWeaponSG556(nint handle) : base(handle) {
  }

  public CWeaponSG556(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}