using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSPlayerPawnBase : CBasePlayerPawn, ICSPlayerPawnBase {

  public CCSPlayerPawnBase(nint handle) : base(handle) {
  }

  public IGameTime_t BlindUntilTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0xD8F889765869ECC5));
  }
  public IGameTime_t BlindStartTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0xD8F88976540D0351));
  }
  public ref bool Respawning {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD8F889769E9D7B99));
  }
  public ref int NumSpawns {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xD8F8897605DCE1E8));
  }
  public ref float IdleTimeSinceLastAction {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD8F8897672DE4B20));
  }
  public ref float NextRadarUpdateTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD8F889760D6C11B8));
  }

  public void CTouchExpansionComponentUpdated() {
    Schema.Update(_Handle, 0xD8F889768A159531);
  }
  public void PingServicesUpdated() {
    Schema.Update(_Handle, 0xD8F889767A1487DF);
  }
  public void PlayerStateUpdated() {
    Schema.Update(_Handle, 0xD8F889769F641BBA);
  }
  public void HasMovedSinceSpawnUpdated() {
    Schema.Update(_Handle, 0xD8F889763D3B1C13);
  }
  public void FlashDurationUpdated() {
    Schema.Update(_Handle, 0xD8F88976E5A995FB);
  }
  public void FlashMaxAlphaUpdated() {
    Schema.Update(_Handle, 0xD8F889763DCF0D29);
  }
  public void ProgressBarStartTimeUpdated() {
    Schema.Update(_Handle, 0xD8F889768148DE8E);
  }
  public void ProgressBarDurationUpdated() {
    Schema.Update(_Handle, 0xD8F88976BCF340B0);
  }
  public void OriginalControllerUpdated() {
    Schema.Update(_Handle, 0xD8F88976511FAE4C);
  }
}