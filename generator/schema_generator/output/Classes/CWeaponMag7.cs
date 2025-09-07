using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CWeaponMag7 : CCSWeaponBaseGun, IWeaponMag7 {

  public CWeaponMag7(nint handle) : base(handle) {
  }

  public CWeaponMag7(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}