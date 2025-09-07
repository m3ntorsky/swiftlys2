using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CWeaponG3SG1 : CCSWeaponBaseGun, IWeaponG3SG1 {

  public CWeaponG3SG1(nint handle) : base(handle) {
  }

  public CWeaponG3SG1(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}