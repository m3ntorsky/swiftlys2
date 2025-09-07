using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CWeaponMAC10 : CCSWeaponBaseGun, IWeaponMAC10 {

  public CWeaponMAC10(nint handle) : base(handle) {
  }

  public CWeaponMAC10(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}