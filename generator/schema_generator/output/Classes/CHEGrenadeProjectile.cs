using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CHEGrenadeProjectile : CBaseCSGrenadeProjectile, IHEGrenadeProjectile {

  public CHEGrenadeProjectile(nint handle) : base(handle) {
  }

  public CHEGrenadeProjectile(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}