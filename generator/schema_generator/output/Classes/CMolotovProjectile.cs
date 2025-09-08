using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CMolotovProjectile : CBaseCSGrenadeProjectile, IMolotovProjectile {

  public CMolotovProjectile(nint handle) : base(handle) {
  }

  public ref bool Detonated {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA239EA8F97D602AF));
  }
  public IIntervalTimer StillTimer {
    get => new IntervalTimer(_Handle + Schema.GetOffset(0xA239EA8F2772246E));
  }
  public ref bool HasBouncedOffPlayer {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA239EA8F2A625F7B));
  }

  public void IsIncGrenadeUpdated() {
    Schema.Update(_Handle, 0xA239EA8F9D1C12B7);
  }
}