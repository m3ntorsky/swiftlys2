using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CDecoyProjectile : CBaseCSGrenadeProjectile, IDecoyProjectile {

  public CDecoyProjectile(nint handle) : base(handle) {
  }

  public CDecoyProjectile(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int DecoyShotTick {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x69629121C4EFED0A));
  }
  public ref int ShotsRemaining {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x6962912188CAE2A2));
  }
  public IGameTime_t ExpireTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x696291216D61853F));
  }
  public ref ushort DecoyWeaponDefIndex {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x69629121A9377E6A));
  }

  public void DecoyShotTickUpdated() {
    Schema.Update(_Handle, 0x69629121C4EFED0A);
  }
}