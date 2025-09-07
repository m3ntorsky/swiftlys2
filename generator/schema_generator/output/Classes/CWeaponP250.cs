using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CWeaponP250 : CCSWeaponBaseGun, IWeaponP250 {

  public CWeaponP250(nint handle) : base(handle) {
  }

  public CWeaponP250(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}