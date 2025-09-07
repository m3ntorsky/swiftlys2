using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSPlayerController_ActionTrackingServices : CPlayerControllerComponent, ICSPlayerController_ActionTrackingServices {

  public CCSPlayerController_ActionTrackingServices(nint handle) : base(handle) {
  }

  public CCSPlayerController_ActionTrackingServices(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVectorEmbeddedNetworkVar< CSPerRoundStats_t > PerRoundStats {
    get => ref _Handle.AsRef<CUtlVectorEmbeddedNetworkVar< CSPerRoundStats_t >>(Schema.GetOffset(0x96DF63C17C8AAE9F));
  }
  public ISMatchStats_t MatchStats {
    get => new CSMatchStats_t(_Handle + Schema.GetOffset(0x96DF63C11729A24D));
  }
  public ref int NumRoundKills {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x96DF63C1C6B90825));
  }
  public ref int NumRoundKillsHeadshots {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x96DF63C196C53F70));
  }
  public ref uint TotalRoundDamageDealt {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x96DF63C12D1B8071));
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