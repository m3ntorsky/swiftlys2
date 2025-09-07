using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CWeaponP90 : CCSWeaponBaseGun, IWeaponP90 {

  public CWeaponP90(nint handle) : base(handle) {
  }

  public CWeaponP90(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}