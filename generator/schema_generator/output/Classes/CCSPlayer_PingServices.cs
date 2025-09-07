using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSPlayer_PingServices : CPlayerPawnComponent, ICSPlayer_PingServices {

  public CCSPlayer_PingServices(nint handle) : base(handle) {
  }

  public CCSPlayer_PingServices(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IGameTime_t PlayerPingTokens {
    get => new GameTime_t(_Handle + Schema.GetOffset(0xC78D79CA55696280));
  }
  public ref CHandle< CBaseEntity > PlayerPing {
    get => ref _Handle.AsRef<CHandle< CBaseEntity >>(Schema.GetOffset(0xC78D79CA464EEA6E));
  }

  public void PlayerPingUpdated() {
    Schema.Update(_Handle, 0xC78D79CA464EEA6E);
  }
}