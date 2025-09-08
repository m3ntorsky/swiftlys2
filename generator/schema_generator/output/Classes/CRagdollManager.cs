using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CRagdollManager : CBaseEntity, IRagdollManager {

  public CRagdollManager(nint handle) : base(handle) {
  }

  public ref int MaxRagdollCount {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x3C67654CC3A8C254));
  }
  public ref bool SaveImportant {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x3C67654CB7710746));
  }
  public ref bool CanTakeDamage {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x3C67654C64446233));
  }

  public void CurrentMaxRagdollCountUpdated() {
    Schema.Update(_Handle, 0x3C67654C8544F4A7);
  }
}