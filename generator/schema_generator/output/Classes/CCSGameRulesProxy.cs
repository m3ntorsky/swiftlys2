using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSGameRulesProxy : CGameRulesProxy, ICSGameRulesProxy {

  public CCSGameRulesProxy(nint handle) : base(handle) {
  }



  public void GameRulesUpdated() {
    Schema.Update(_Handle, 0x242D3ADB925C1F40);
  }
}