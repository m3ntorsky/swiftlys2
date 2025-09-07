using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CWeaponMP9 : CCSWeaponBaseGun, IWeaponMP9 {

  public CWeaponMP9(nint handle) : base(handle) {
  }

  public CWeaponMP9(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}