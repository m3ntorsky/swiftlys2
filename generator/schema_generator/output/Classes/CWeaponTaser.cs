using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CWeaponTaser : CCSWeaponBaseGun, IWeaponTaser {

  public CWeaponTaser(nint handle) : base(handle) {
  }

  public CWeaponTaser(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IGameTime_t FireTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0xA91A6CB965DBC00C));
  }
  public ref int LastAttackTick {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xA91A6CB90BCAAD3C));
  }

  public void FireTimeUpdated() {
    Schema.Update(_Handle, 0xA91A6CB965DBC00C);
  }
}