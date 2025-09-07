using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSPlayer_BulletServices : CPlayerPawnComponent, ICSPlayer_BulletServices {

  public CCSPlayer_BulletServices(nint handle) : base(handle) {
  }

  public CCSPlayer_BulletServices(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int TotalHitsOnServer {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x39B0E99E8006CF29));
  }

  public void TotalHitsOnServerUpdated() {
    Schema.Update(_Handle, 0x39B0E99E8006CF29);
  }
}