using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSPlayer_PingServices : CPlayerPawnComponent, ICSPlayer_PingServices {

  public CCSPlayer_PingServices(nint handle) : base(handle) {
  }

  public IGameTime_t PlayerPingTokens {
    get => new GameTime_t(_Handle, 0xC78D79CA55696280, 5, 4, 4);
  }

  public void PlayerPingUpdated() {
    Schema.Update(_Handle, 0xC78D79CA464EEA6E);
  }
}