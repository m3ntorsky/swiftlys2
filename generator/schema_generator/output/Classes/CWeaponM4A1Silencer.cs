using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CWeaponM4A1Silencer : CCSWeaponBaseGun, IWeaponM4A1Silencer {

  public CWeaponM4A1Silencer(nint handle) : base(handle) {
  }

  public CWeaponM4A1Silencer(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}