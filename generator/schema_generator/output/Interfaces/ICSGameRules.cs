using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICSGameRules : ITeamplayRules {

  public ref bool FreezePeriod { get; }
  
  public ref bool WarmupPeriod { get; }
  
  public IGameTime_t WarmupPeriodEnd { get; }
  
  public IGameTime_t WarmupPeriodStart { get; }
  
  public ref bool TerroristTimeOutActive { get; }
  
  public ref bool CTTimeOutActive { get; }
  
  public ref float TerroristTimeOutRemaining { get; }
  
  public ref float CTTimeOutRemaining { get; }
  
  public ref int TerroristTimeOuts { get; }
  
  public ref int CTTimeOuts { get; }
  
  public ref bool TechnicalTimeOut { get; }
  
  public ref bool MatchWaitingForResume { get; }
  
  public ref int RoundTime { get; }
  
  public ref float MatchStartTime { get; }
  
  public IGameTime_t RoundStartTime { get; }
  
  public IGameTime_t RestartRoundTime { get; }
  
  public ref bool GameRestart { get; }
  
  public ref float GameStartTime { get; }
  
  public ref float TimeUntilNextPhaseStarts { get; }
  
  public ref int GamePhase { get; }
  
  public ref int TotalRoundsPlayed { get; }
  
  public ref int RoundsPlayedThisPhase { get; }
  
  public ref int OvertimePlaying { get; }
  
  public ref int HostagesRemaining { get; }
  
  public ref bool AnyHostageReached { get; }
  
  public ref bool MapHasBombTarget { get; }
  
  public ref bool MapHasRescueZone { get; }
  
  public ref bool MapHasBuyZone { get; }
  
  public ref bool IsQueuedMatchmaking { get; }
  
  public ref int QueuedMatchmakingMode { get; }
  
  public ref bool IsValveDS { get; }
  
  public ref bool LogoMap { get; }
  
  public ref bool PlayAllStepSoundsOnServer { get; }
  
  public ref int SpectatorSlotCount { get; }
  
  public ref int MatchDevice { get; }
  
  public ref bool HasMatchStarted { get; }
  
  public ref int NextMapInMapgroup { get; }
  
  public ISchemaFixedString TournamentEventName { get; }
  
  public ISchemaFixedString TournamentEventStage { get; }
  
  public ISchemaFixedString MatchStatTxt { get; }
  
  public ISchemaFixedString TournamentPredictionsTxt { get; }
  
  public ref int TournamentPredictionsPct { get; }
  
  public IGameTime_t CMMItemDropRevealStartTime { get; }
  
  public IGameTime_t CMMItemDropRevealEndTime { get; }
  
  public ref bool IsDroppingItems { get; }
  
  public ref bool IsQuestEligible { get; }
  
  public ref bool IsHltvActive { get; }
  
  public ISchemaFixedArray<ushort> ProhibitedItemIndices { get; }
  
  public ISchemaFixedArray<uint> TournamentActiveCasterAccounts { get; }
  
  public ref int NumBestOfMaps { get; }
  
  public ref int HalloweenMaskListSeed { get; }
  
  public ref bool BombDropped { get; }
  
  public ref bool BombPlanted { get; }
  
  public ref int RoundWinStatus { get; }
  
  public ref int RoundWinReason { get; }
  
  public ref bool TCantBuy { get; }
  
  public ref bool CTCantBuy { get; }
  
  public ISchemaFixedArray<int> MatchStats_RoundResults { get; }
  
  public ISchemaFixedArray<int> MatchStats_PlayersAlive_CT { get; }
  
  public ISchemaFixedArray<int> MatchStats_PlayersAlive_T { get; }
  
  public ISchemaFixedArray<float> TeamRespawnWaveTimes { get; }
  
  public IGameTime_t NextRespawnWave { get; }
  
  public ref Vector MinimapMins { get; }
  
  public ref Vector MinimapMaxs { get; }
  
  public ISchemaFixedArray<float> MinimapVerticalSectionHeights { get; }
  
  public ref ulong UllLocalMatchID { get; }
  
  public ISchemaFixedArray<int> EndMatchMapGroupVoteTypes { get; }
  
  public ISchemaFixedArray<int> EndMatchMapGroupVoteOptions { get; }
  
  public ref int EndMatchMapVoteWinner { get; }
  
  public ref int NumConsecutiveCTLoses { get; }
  
  public ref int NumConsecutiveTerroristLoses { get; }
  
  public ref bool HasHostageBeenTouched { get; }
  
  public IGameTime_t IntermissionStartTime { get; }
  
  public IGameTime_t IntermissionEndTime { get; }
  
  public ref bool LevelInitialized { get; }
  
  public ref int TotalRoundsPlayed { get; }
  
  public ref int UnBalancedRounds { get; }
  
  public ref bool EndMatchOnRoundReset { get; }
  
  public ref bool EndMatchOnThink { get; }
  
  public ref int FreezeTime { get; }
  
  public ref int NumTerrorist { get; }
  
  public ref int NumCT { get; }
  
  public ref int NumSpawnableTerrorist { get; }
  
  public ref int NumSpawnableCT { get; }
  
  public ref CUtlVector<int> SelectedHostageSpawnIndices { get; }
  
  public ref int SpawnPointsRandomSeed { get; }
  
  public ref bool FirstConnected { get; }
  
  public ref bool CompleteReset { get; }
  
  public ref bool PickNewTeamsOnReset { get; }
  
  public ref bool ScrambleTeamsOnRestart { get; }
  
  public ref bool SwapTeamsOnRestart { get; }
  
  public ref CUtlVector<int> EndMatchTiedVotes { get; }
  
  public ref bool NeedToAskPlayersForContinueVote { get; }
  
  public ref uint NumQueuedMatchmakingAccounts { get; }
  
  public ref float AvgPlayerRank { get; }
  
  public ref CString QueuedMatchmakingReservationString { get; }
  
  public ref uint NumTotalTournamentDrops { get; }
  
  public ref uint NumSpectatorsCountMax { get; }
  
  public ref uint NumSpectatorsCountMaxTV { get; }
  
  public ref uint NumSpectatorsCountMaxLnk { get; }
  
  public ref int CTsAliveAtFreezetimeEnd { get; }
  
  public ref int TerroristsAliveAtFreezetimeEnd { get; }
  
  public ref bool ForceTeamChangeSilent { get; }
  
  public ref bool LoadingRoundBackupData { get; }
  
  public ref int MatchInfoShowType { get; }
  
  public ref float MatchInfoDecidedTime { get; }
  
  public ref int MTeamDMLastWinningTeamNumber { get; }
  
  public ref float MTeamDMLastThinkTime { get; }
  
  public ref float TeamDMLastAnnouncementTime { get; }
  
  public ref int AccountTerrorist { get; }
  
  public ref int AccountCT { get; }
  
  public ref int SpawnPointCount_Terrorist { get; }
  
  public ref int SpawnPointCount_CT { get; }
  
  public ref int MaxNumTerrorists { get; }
  
  public ref int MaxNumCTs { get; }
  
  public ref int LoserBonusMostRecentTeam { get; }
  
  public ref float TmNextPeriodicThink { get; }
  
  public ref bool VoiceWonMatchBragFired { get; }
  
  public ref float WarmupNextChatNoticeTime { get; }
  
  public ref int HostagesRescued { get; }
  
  public ref int HostagesTouched { get; }
  
  public ref float NextHostageAnnouncement { get; }
  
  public ref bool NoTerroristsKilled { get; }
  
  public ref bool NoCTsKilled { get; }
  
  public ref bool NoEnemiesKilled { get; }
  
  public ref bool CanDonateWeapons { get; }
  
  public ref float FirstKillTime { get; }
  
  public ref float FirstBloodTime { get; }
  
  public ref bool HostageWasInjured { get; }
  
  public ref bool HostageWasKilled { get; }
  
  public ref bool VoteCalled { get; }
  
  public ref bool ServerVoteOnReset { get; }
  
  public ref float VoteCheckThrottle { get; }
  
  public ref bool BuyTimeEnded { get; }
  
  public ref int LastFreezeEndBeep { get; }
  
  public ref bool TargetBombed { get; }
  
  public ref bool BombDefused { get; }
  
  public ref bool MapHasBombZone { get; }
  
  public ref Vector MainCTSpawnPos { get; }
  
  public ref CUtlVector<PointerTo<SpawnPoint>> CTSpawnPointsMasterList { get; }
  
  public ref CUtlVector<PointerTo<SpawnPoint>> TerroristSpawnPointsMasterList { get; }
  
  public ref bool RespawningAllRespawnablePlayers { get; }
  
  public ref int NextCTSpawnPoint { get; }
  
  public ref float CTSpawnPointUsedTime { get; }
  
  public ref int NextTerroristSpawnPoint { get; }
  
  public ref float TerroristSpawnPointUsedTime { get; }
  
  public ref CUtlVector<PointerTo<SpawnPoint>> CTSpawnPoints { get; }
  
  public ref CUtlVector<PointerTo<SpawnPoint>> TerroristSpawnPoints { get; }
  
  public ref bool IsUnreservedGameServer { get; }
  
  public ref float AutobalanceDisplayTime { get; }
  
  public ref bool AllowWeaponSwitch { get; }
  
  public ref bool RoundTimeWarningTriggered { get; }
  
  public IGameTime_t PhaseChangeAnnouncementTime { get; }
  
  public ref float NextUpdateTeamClanNamesTime { get; }
  
  public IGameTime_t LastThinkTime { get; }
  
  public ref float AccumulatedRoundOffDamage { get; }
  
  public ref int ShorthandedBonusLastEvalRound { get; }
  
  public ref int MatchAbortedEarlyReason { get; }
  
  public ref bool HasTriggeredRoundStartMusic { get; }
  
  public ref bool SwitchingTeamsAtRoundReset { get; }
  
  public ICSGameModeRules GameModeRules { get; }
  
  public ISchemaUntypedField BtGlobalBlackboard { get; }
  
  public ref CHandle<CBaseEntity> PlayerResource { get; }
  
  public IRetakeGameRules RetakeRules { get; }
  
  public ref CUtlVector<int> TeamUniqueKillWeaponsMatch { get; }
  
  public ISchemaFixedArray<bool> TeamLastKillUsedUniqueWeaponMatch { get; }
  
  public ref byte MatchEndCount { get; }
  
  public ref int TTeamIntroVariant { get; }
  
  public ref int CTTeamIntroVariant { get; }
  
  public ref bool TeamIntroPeriod { get; }
  
  public IGameTime_t TeamIntroPeriodEnd { get; }
  
  public ref bool PlayedTeamIntroVO { get; }
  
  public ref int RoundEndWinnerTeam { get; }
  
  public ref int RoundEndReason { get; }
  
  public ref bool RoundEndShowTimerDefend { get; }
  
  public ref int RoundEndTimerTime { get; }
  
  public ref CUtlString RoundEndFunFactToken { get; }
  
  public ref CPlayerSlot RoundEndFunFactPlayerSlot { get; }
  
  public ref int RoundEndFunFactData1 { get; }
  
  public ref int RoundEndFunFactData2 { get; }
  
  public ref int RoundEndFunFactData3 { get; }
  
  public ref CUtlString RoundEndMessage { get; }
  
  public ref int RoundEndPlayerCount { get; }
  
  public ref bool RoundEndNoMusic { get; }
  
  public ref int RoundEndLegacy { get; }
  
  public ref byte RoundEndCount { get; }
  
  public ref int RoundStartRoundNumber { get; }
  
  public ref byte RoundStartCount { get; }
  
  public ref double LastPerfSampleTime { get; }
  
}