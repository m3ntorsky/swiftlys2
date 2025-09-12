using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSPlayerController : CBasePlayerController, ICSPlayerController {

  public CCSPlayerController(nint handle) : base(handle) {
  }

  public ref bool AttemptedToGetColor {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x28ECD7A1590EFE29));
  }
  public ref int TeammatePreferredColor {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x28ECD7A1E2798140));
  }
  public ref bool TeamChanged {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x28ECD7A1A2481D48));
  }
  public ref bool InSwitchTeam {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x28ECD7A13009D36F));
  }
  public ref bool HasSeenJoinGame {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x28ECD7A181EE59E2));
  }
  public ref bool JustBecameSpectator {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x28ECD7A190F9514D));
  }
  public ref bool SwitchTeamsOnNextRoundReset {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x28ECD7A1B1B483A2));
  }
  public ref bool RemoveAllItemsOnNextRoundReset {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x28ECD7A140A604B3));
  }
  public IGameTime_t LastJoinTeamTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x28ECD7A1B2DAFB07));
  }
  public ISchemaFixedString ClanName {
    get => new SchemaFixedString(_Handle, 0x28ECD7A1B9D2364F, 32, 1, 1);
  }
  public ref int DraftIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x28ECD7A1EA3A0EAD));
  }
  public ref uint MsQueuedModeDisconnectionTimestamp {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x28ECD7A1E91830DF));
  }
  public ref uint UiAbandonRecordedReason {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x28ECD7A1C9DD33D0));
  }
  public ref uint NetworkDisconnectionReason {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x28ECD7A157EEC70A));
  }
  public ref bool CannotBeKicked {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x28ECD7A135B7EA3C));
  }
  public ref bool EverFullyConnected {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x28ECD7A1F301AB32));
  }
  public ref bool AbandonAllowsSurrender {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x28ECD7A14318A3BE));
  }
  public ref bool AbandonOffersInstantSurrender {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x28ECD7A1A31D03BC));
  }
  public ref bool Disconnection1MinWarningPrinted {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x28ECD7A1D121B50C));
  }
  public ref bool ScoreReported {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x28ECD7A128229D7A));
  }
  public ref bool HasBeenControlledByPlayerThisRound {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x28ECD7A1FCA2F525));
  }
  public ref int BotsControlledThisRound {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x28ECD7A1059DDC83));
  }
  public ref int DesiredObserverMode {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x28ECD7A17704B120));
  }
  public ref CHandle<IEntityInstance> DesiredObserverTarget {
    get => ref _Handle.AsRef<CHandle<IEntityInstance>>(Schema.GetOffset(0x28ECD7A161F130C8));
  }
  public ref int RoundScore {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x28ECD7A1AA870DFE));
  }
  public ref int RoundsWon {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x28ECD7A1866D1FEF));
  }
  public ref int UpdateCounter {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x28ECD7A15D476034));
  }
  public ref float SmoothedPing {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x28ECD7A1BB8724DC));
  }
  public IIntervalTimer LastHeldVoteTimer {
    get => new IntervalTimer(_Handle + Schema.GetOffset(0x28ECD7A1CBB0044F));
  }
  public ref bool ShowHints {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x28ECD7A181BEA642));
  }
  public ref int NextTimeCheck {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x28ECD7A17E63BC34));
  }
  public ref bool JustDidTeamKill {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x28ECD7A124328709));
  }
  public ref bool PunishForTeamKill {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x28ECD7A1181B7CB2));
  }
  public ref bool GaveTeamDamageWarning {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x28ECD7A1A129DCAC));
  }
  public ref bool GaveTeamDamageWarningThisRound {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x28ECD7A1AEBE6F90));
  }
  public ref double DblLastReceivedPacketPlatFloatTime {
    get => ref _Handle.AsRef<double>(Schema.GetOffset(0x28ECD7A1D8EB630A));
  }
  public IGameTime_t LastTeamDamageWarningTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x28ECD7A1570CFFD2));
  }
  public IGameTime_t LastTimePlayerWasDisconnectedForPawnsRemove {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x28ECD7A196817413));
  }
  public ref uint SuspiciousHitCount {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x28ECD7A102ECB89E));
  }
  public ref uint NonSuspiciousHitStreak {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x28ECD7A1D29AD1EE));
  }

  public void InGameMoneyServicesUpdated() {
    Schema.Update(_Handle, 0x28ECD7A184B7AA82);
  }
  public void InventoryServicesUpdated() {
    Schema.Update(_Handle, 0x28ECD7A1E5A0A8C9);
  }
  public void ActionTrackingServicesUpdated() {
    Schema.Update(_Handle, 0x28ECD7A1B8174144);
  }
  public void DamageServicesUpdated() {
    Schema.Update(_Handle, 0x28ECD7A1A2CE0372);
  }
  public void PingUpdated() {
    Schema.Update(_Handle, 0x28ECD7A15FA2671C);
  }
  public void HasCommunicationAbuseMuteUpdated() {
    Schema.Update(_Handle, 0x28ECD7A189BEC204);
  }
  public void UiCommunicationMuteFlagsUpdated() {
    Schema.Update(_Handle, 0x28ECD7A1DD210AC7);
  }
  public void CrosshairCodesUpdated() {
    Schema.Update(_Handle, 0x28ECD7A10FF7211E);
  }
  public void PendingTeamNumUpdated() {
    Schema.Update(_Handle, 0x28ECD7A1F6CB4D26);
  }
  public void ForceTeamTimeUpdated() {
    Schema.Update(_Handle, 0x28ECD7A143249332);
  }
  public void CompTeammateColorUpdated() {
    Schema.Update(_Handle, 0x28ECD7A1F22ED09E);
  }
  public void EverPlayedOnTeamUpdated() {
    Schema.Update(_Handle, 0x28ECD7A16A63A242);
  }
  public void ClanUpdated() {
    Schema.Update(_Handle, 0x28ECD7A10A2F1774);
  }
  public void CoachingTeamUpdated() {
    Schema.Update(_Handle, 0x28ECD7A1B80B18EB);
  }
  public void PlayerDominatedUpdated() {
    Schema.Update(_Handle, 0x28ECD7A1B882C893);
  }
  public void PlayerDominatingMeUpdated() {
    Schema.Update(_Handle, 0x28ECD7A17C8F55E4);
  }
  public void CompetitiveRankingUpdated() {
    Schema.Update(_Handle, 0x28ECD7A1D82CC087);
  }
  public void CompetitiveWinsUpdated() {
    Schema.Update(_Handle, 0x28ECD7A192776C10);
  }
  public void CompetitiveRankTypeUpdated() {
    Schema.Update(_Handle, 0x28ECD7A15803DF71);
  }
  public void CompetitiveRankingPredicted_WinUpdated() {
    Schema.Update(_Handle, 0x28ECD7A1C32AD2BC);
  }
  public void CompetitiveRankingPredicted_LossUpdated() {
    Schema.Update(_Handle, 0x28ECD7A1BDCCE5ED);
  }
  public void CompetitiveRankingPredicted_TieUpdated() {
    Schema.Update(_Handle, 0x28ECD7A138CA4C74);
  }
  public void EndMatchNextMapVoteUpdated() {
    Schema.Update(_Handle, 0x28ECD7A17AB3943C);
  }
  public void ActiveQuestIdUpdated() {
    Schema.Update(_Handle, 0x28ECD7A1003CF113);
  }
  public void RtActiveMissionPeriodUpdated() {
    Schema.Update(_Handle, 0x28ECD7A1E463EDC8);
  }
  public void QuestProgressReasonUpdated() {
    Schema.Update(_Handle, 0x28ECD7A1BFFEC946);
  }
  public void PlayerTvControlFlagsUpdated() {
    Schema.Update(_Handle, 0x28ECD7A138E01A7D);
  }
  public void DisconnectionTickUpdated() {
    Schema.Update(_Handle, 0x28ECD7A1B813FC7A);
  }
  public void ControllingBotUpdated() {
    Schema.Update(_Handle, 0x28ECD7A118EA3C63);
  }
  public void HasControlledBotThisRoundUpdated() {
    Schema.Update(_Handle, 0x28ECD7A18003721A);
  }
  public void CanControlObservedBotUpdated() {
    Schema.Update(_Handle, 0x28ECD7A1F6712E5B);
  }
  public void PlayerPawnUpdated() {
    Schema.Update(_Handle, 0x28ECD7A1D6C93E7C);
  }
  public void ObserverPawnUpdated() {
    Schema.Update(_Handle, 0x28ECD7A154DF971F);
  }
  public void PawnIsAliveUpdated() {
    Schema.Update(_Handle, 0x28ECD7A13DB3C8D0);
  }
  public void PawnHealthUpdated() {
    Schema.Update(_Handle, 0x28ECD7A196CA4790);
  }
  public void PawnArmorUpdated() {
    Schema.Update(_Handle, 0x28ECD7A1C59D2751);
  }
  public void PawnHasDefuserUpdated() {
    Schema.Update(_Handle, 0x28ECD7A1D8AE243B);
  }
  public void PawnHasHelmetUpdated() {
    Schema.Update(_Handle, 0x28ECD7A130AB7684);
  }
  public void PawnCharacterDefIndexUpdated() {
    Schema.Update(_Handle, 0x28ECD7A10A67310B);
  }
  public void PawnLifetimeStartUpdated() {
    Schema.Update(_Handle, 0x28ECD7A1574766CB);
  }
  public void PawnLifetimeEndUpdated() {
    Schema.Update(_Handle, 0x28ECD7A1A8D1608E);
  }
  public void PawnBotDifficultyUpdated() {
    Schema.Update(_Handle, 0x28ECD7A10C90C802);
  }
  public void OriginalControllerOfCurrentPawnUpdated() {
    Schema.Update(_Handle, 0x28ECD7A168975EB8);
  }
  public void ScoreUpdated() {
    Schema.Update(_Handle, 0x28ECD7A139E7DEAE);
  }
  public void RecentKillQueueUpdated() {
    Schema.Update(_Handle, 0x28ECD7A12540EEA5);
  }
  public void FirstKillUpdated() {
    Schema.Update(_Handle, 0x28ECD7A1FEF75779);
  }
  public void KillCountUpdated() {
    Schema.Update(_Handle, 0x28ECD7A15CC907F4);
  }
  public void MvpNoMusicUpdated() {
    Schema.Update(_Handle, 0x28ECD7A131EB0C5C);
  }
  public void MvpReasonUpdated() {
    Schema.Update(_Handle, 0x28ECD7A1F13150E5);
  }
  public void MusicKitIDUpdated() {
    Schema.Update(_Handle, 0x28ECD7A185940554);
  }
  public void MusicKitMVPsUpdated() {
    Schema.Update(_Handle, 0x28ECD7A188B9FF33);
  }
  public void MVPsUpdated() {
    Schema.Update(_Handle, 0x28ECD7A1CD5FFC12);
  }
  public void FireBulletsSeedSynchronizedUpdated() {
    Schema.Update(_Handle, 0x28ECD7A1FB25C915);
  }
}