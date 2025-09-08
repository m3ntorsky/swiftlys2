using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSPlayerController_ActionTrackingServices : CPlayerControllerComponent, ICSPlayerController_ActionTrackingServices {

  public CCSPlayerController_ActionTrackingServices(nint handle) : base(handle) {
  }



  public void PerRoundStatsUpdated() {
    Schema.Update(_Handle, 0x96DF63C17C8AAE9F);
  }
  public void MatchStatsUpdated() {
    Schema.Update(_Handle, 0x96DF63C11729A24D);
  }
  public void NumRoundKillsUpdated() {
    Schema.Update(_Handle, 0x96DF63C1C6B90825);
  }
  public void NumRoundKillsHeadshotsUpdated() {
    Schema.Update(_Handle, 0x96DF63C196C53F70);
  }
  public void TotalRoundDamageDealtUpdated() {
    Schema.Update(_Handle, 0x96DF63C12D1B8071);
  }
}