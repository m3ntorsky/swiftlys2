using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CWeaponMP7 : CCSWeaponBaseGun, IWeaponMP7 {

  public CWeaponMP7(nint handle) : base(handle) {
  }

  public CWeaponMP7(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}