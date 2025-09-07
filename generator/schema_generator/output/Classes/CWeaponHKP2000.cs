using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CWeaponHKP2000 : CCSWeaponBaseGun, IWeaponHKP2000 {

  public CWeaponHKP2000(nint handle) : base(handle) {
  }

  public CWeaponHKP2000(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}