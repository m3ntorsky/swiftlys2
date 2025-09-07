using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CWeaponSSG08 : CCSWeaponBaseGun, IWeaponSSG08 {

  public CWeaponSSG08(nint handle) : base(handle) {
  }

  public CWeaponSSG08(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}