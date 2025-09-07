using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CWeaponSCAR20 : CCSWeaponBaseGun, IWeaponSCAR20 {

  public CWeaponSCAR20(nint handle) : base(handle) {
  }

  public CWeaponSCAR20(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}