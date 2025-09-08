using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICSPlayerController : IBasePlayerController {

  public ICSPlayerController_InGameMoneyServices InGameMoneyServices { get; }
  
  public ICSPlayerController_InventoryServices InventoryServices { get; }
  
  public ICSPlayerController_ActionTrackingServices ActionTrackingServices { get; }
  
  public ICSPlayerController_DamageServices DamageServices { get; }
  
  public ref uint Ping { get; }
  
  public ref bool HasCommunicationAbuseMute { get; }
  
  public ref uint UiCommunicationMuteFlags { get; }
  
  public ref CUtlSymbolLarge CrosshairCodes { get; }
  
  public ref byte PendingTeamNum { get; }
  
  public IGameTime_t ForceTeamTime { get; }
  
  public ref int CompTeammateColor { get; }
  
  public ref bool EverPlayedOnTeam { get; }
  
  public ref bool AttemptedToGetColor { get; }
  
  public ref int TeammatePreferredColor { get; }
  
  public ref bool TeamChanged { get; }
  
  public ref bool InSwitchTeam { get; }
  
  public ref bool HasSeenJoinGame { get; }
  
  public ref bool JustBecameSpectator { get; }
  
  public ref bool SwitchTeamsOnNextRoundReset { get; }
  
  public ref bool RemoveAllItemsOnNextRoundReset { get; }
  
  public IGameTime_t LastJoinTeamTime { get; }
  
  public ref CUtlSymbolLarge Clan { get; }
  
  public ISchemaFixedString ClanName { get; }
  
  public ref int CoachingTeam { get; }
  
  public ref ulong PlayerDominated { get; }
  
  public ref ulong PlayerDominatingMe { get; }
  
  public ref int CompetitiveRanking { get; }
  
  public ref int CompetitiveWins { get; }
  
  public ref byte CompetitiveRankType { get; }
  
  public ref int CompetitiveRankingPredicted_Win { get; }
  
  public ref int CompetitiveRankingPredicted_Loss { get; }
  
  public ref int CompetitiveRankingPredicted_Tie { get; }
  
  public ref int EndMatchNextMapVote { get; }
  
  public ref ushort ActiveQuestId { get; }
  
  public ref uint RtActiveMissionPeriod { get; }
  
  public ref QuestProgress::Reason QuestProgressReason { get; }
  
  public ref uint PlayerTvControlFlags { get; }
  
  public ref int DraftIndex { get; }
  
  public ref uint MsQueuedModeDisconnectionTimestamp { get; }
  
  public ref uint UiAbandonRecordedReason { get; }
  
  public ref uint NetworkDisconnectionReason { get; }
  
  public ref bool CannotBeKicked { get; }
  
  public ref bool EverFullyConnected { get; }
  
  public ref bool AbandonAllowsSurrender { get; }
  
  public ref bool AbandonOffersInstantSurrender { get; }
  
  public ref bool Disconnection1MinWarningPrinted { get; }
  
  public ref bool ScoreReported { get; }
  
  public ref int DisconnectionTick { get; }
  
  public ref bool ControllingBot { get; }
  
  public ref bool HasControlledBotThisRound { get; }
  
  public ref bool HasBeenControlledByPlayerThisRound { get; }
  
  public ref int BotsControlledThisRound { get; }
  
  public ref bool CanControlObservedBot { get; }
  
  public CHandle<ICSPlayerPawn> PlayerPawn { get; }
  
  public CHandle<ICSObserverPawn> ObserverPawn { get; }
  
  public ref int DesiredObserverMode { get; }
  
  public ref CEntityHandle DesiredObserverTarget { get; }
  
  public ref bool PawnIsAlive { get; }
  
  public ref uint PawnHealth { get; }
  
  public ref int PawnArmor { get; }
  
  public ref bool PawnHasDefuser { get; }
  
  public ref bool PawnHasHelmet { get; }
  
  public ref ushort PawnCharacterDefIndex { get; }
  
  public ref int PawnLifetimeStart { get; }
  
  public ref int PawnLifetimeEnd { get; }
  
  public ref int PawnBotDifficulty { get; }
  
  public CHandle<ICSPlayerController> OriginalControllerOfCurrentPawn { get; }
  
  public ref int Score { get; }
  
  public ref int RoundScore { get; }
  
  public ref int RoundsWon { get; }
  
  public ISchemaFixedArray<byte> RecentKillQueue { get; }
  
  public ref byte FirstKill { get; }
  
  public ref byte KillCount { get; }
  
  public ref bool MvpNoMusic { get; }
  
  public ref int MvpReason { get; }
  
  public ref int MusicKitID { get; }
  
  public ref int MusicKitMVPs { get; }
  
  public ref int MVPs { get; }
  
  public ref int UpdateCounter { get; }
  
  public ref float SmoothedPing { get; }
  
  public IIntervalTimer LastHeldVoteTimer { get; }
  
  public ref bool ShowHints { get; }
  
  public ref int NextTimeCheck { get; }
  
  public ref bool JustDidTeamKill { get; }
  
  public ref bool PunishForTeamKill { get; }
  
  public ref bool GaveTeamDamageWarning { get; }
  
  public ref bool GaveTeamDamageWarningThisRound { get; }
  
  public ref double DblLastReceivedPacketPlatFloatTime { get; }
  
  public IGameTime_t LastTeamDamageWarningTime { get; }
  
  public IGameTime_t LastTimePlayerWasDisconnectedForPawnsRemove { get; }
  
  public ref uint SuspiciousHitCount { get; }
  
  public ref uint NonSuspiciousHitStreak { get; }
  
  public ref bool FireBulletsSeedSynchronized { get; }
  
}