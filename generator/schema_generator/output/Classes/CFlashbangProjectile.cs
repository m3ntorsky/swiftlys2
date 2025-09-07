using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFlashbangProjectile : CBaseCSGrenadeProjectile, IFlashbangProjectile {

  public CFlashbangProjectile(nint handle) : base(handle) {
  }

  public CFlashbangProjectile(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float TimeToDetonate {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9F4F2EA190E2E597));
  }
  public ref byte NumOpponentsHit {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x9F4F2EA1CA7913A4));
  }
  public ref byte NumTeammatesHit {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x9F4F2EA1BC5B8F41));
  }


}